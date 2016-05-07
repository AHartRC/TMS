#region Library Imports

using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using TechnicalMarineSolutions.Models.Binding;
using TechnicalMarineSolutions.Models.Context;

#endregion

namespace TechnicalMarineSolutions.Areas.Administration.Controllers
{
	public class PostalAddressController : Controller
	{
		private readonly ApplicationDbContext db = new ApplicationDbContext();

		// GET: Administration/PostalAddress
		public async Task<ActionResult> Index()
		{
			var postalAddresses = db.PostalAddresses.Include(p => p.Person);
			return View(await postalAddresses.ToListAsync());
		}

		// GET: Administration/PostalAddress/Details/5
		public async Task<ActionResult> Details(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			PostalAddress postalAddress = await db.PostalAddresses.FindAsync(id);
			if (postalAddress == null)
			{
				return HttpNotFound();
			}
			return View(postalAddress);
		}

		// GET: Administration/PostalAddress/Create
		public ActionResult Create()
		{
			ViewBag.PersonalInfoId = new SelectList(db.PersonalInfoes, "Id", "FirstName");
			return View();
		}

		// POST: Administration/PostalAddress/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Create(
			[Bind(
				Include = "Id,PersonalInfoId,AddressType,RecordStatus,Recipient,Attention,Address1,Address2,City,State,PostalCode")] PostalAddress postalAddress)
		{
			if (ModelState.IsValid)
			{
				db.PostalAddresses.Add(postalAddress);
				await db.SaveChangesAsync();
				return RedirectToAction("Index");
			}

			ViewBag.PersonalInfoId = new SelectList(db.PersonalInfoes, "Id", "FirstName", postalAddress.PersonalInfoId);
			return View(postalAddress);
		}

		// GET: Administration/PostalAddress/Edit/5
		public async Task<ActionResult> Edit(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			PostalAddress postalAddress = await db.PostalAddresses.FindAsync(id);
			if (postalAddress == null)
			{
				return HttpNotFound();
			}
			ViewBag.PersonalInfoId = new SelectList(db.PersonalInfoes, "Id", "FirstName", postalAddress.PersonalInfoId);
			return View(postalAddress);
		}

		// POST: Administration/PostalAddress/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Edit(
			[Bind(
				Include = "Id,PersonalInfoId,AddressType,RecordStatus,Recipient,Attention,Address1,Address2,City,State,PostalCode")] PostalAddress postalAddress)
		{
			if (ModelState.IsValid)
			{
				db.Entry(postalAddress)
				.State = EntityState.Modified;
				await db.SaveChangesAsync();
				return RedirectToAction("Index");
			}
			ViewBag.PersonalInfoId = new SelectList(db.PersonalInfoes, "Id", "FirstName", postalAddress.PersonalInfoId);
			return View(postalAddress);
		}

		// GET: Administration/PostalAddress/Delete/5
		public async Task<ActionResult> Delete(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			PostalAddress postalAddress = await db.PostalAddresses.FindAsync(id);
			if (postalAddress == null)
			{
				return HttpNotFound();
			}
			return View(postalAddress);
		}

		// POST: Administration/PostalAddress/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> DeleteConfirmed(long id)
		{
			PostalAddress postalAddress = await db.PostalAddresses.FindAsync(id);
			db.PostalAddresses.Remove(postalAddress);
			await db.SaveChangesAsync();
			return RedirectToAction("Index");
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				db.Dispose();
			}
			base.Dispose(disposing);
		}
	}
}