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
	public class PersonalInfoController : Controller
	{
		private readonly ApplicationDbContext db = new ApplicationDbContext();

		// GET: Administration/PersonalInfo
		public async Task<ActionResult> Index()
		{
			var personalInfoes = db.PersonalInfoes.Include(p => p.User);
			return View(await personalInfoes.ToListAsync());
		}

		// GET: Administration/PersonalInfo/Details/5
		public async Task<ActionResult> Details(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Person personalInfo = await db.PersonalInfoes.FindAsync(id);
			if (personalInfo == null)
			{
				return HttpNotFound();
			}
			return View(personalInfo);
		}

		// GET: Administration/PersonalInfo/Create
		public ActionResult Create()
		{
			ViewBag.UserInfoId = new SelectList(db.UserInfoes, "Id", "UserId");
			return View();
		}

		// POST: Administration/PersonalInfo/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Create(
			[Bind(Include = "Id,UserInfoId,RecordStatus,FirstName,MiddleName,LastName,Hometown,CurrentTown,BirthDate")] Person personalInfo)
		{
			if (ModelState.IsValid)
			{
				db.PersonalInfoes.Add(personalInfo);
				await db.SaveChangesAsync();
				return RedirectToAction("Index");
			}

			ViewBag.UserInfoId = new SelectList(db.UserInfoes, "Id", "UserId", personalInfo.UserId);
			return View(personalInfo);
		}

		// GET: Administration/PersonalInfo/Edit/5
		public async Task<ActionResult> Edit(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Person personalInfo = await db.PersonalInfoes.FindAsync(id);
			if (personalInfo == null)
			{
				return HttpNotFound();
			}
			ViewBag.UserInfoId = new SelectList(db.UserInfoes, "Id", "UserId", personalInfo.UserId);
			return View(personalInfo);
		}

		// POST: Administration/PersonalInfo/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Edit(
			[Bind(Include = "Id,UserInfoId,RecordStatus,FirstName,MiddleName,LastName,Hometown,CurrentTown,BirthDate")] Person personalInfo)
		{
			if (ModelState.IsValid)
			{
				db.Entry(personalInfo)
				.State = EntityState.Modified;
				await db.SaveChangesAsync();
				return RedirectToAction("Index");
			}
			ViewBag.UserInfoId = new SelectList(db.UserInfoes, "Id", "UserId", personalInfo.UserId);
			return View(personalInfo);
		}

		// GET: Administration/PersonalInfo/Delete/5
		public async Task<ActionResult> Delete(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Person personalInfo = await db.PersonalInfoes.FindAsync(id);
			if (personalInfo == null)
			{
				return HttpNotFound();
			}
			return View(personalInfo);
		}

		// POST: Administration/PersonalInfo/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> DeleteConfirmed(long id)
		{
			Person personalInfo = await db.PersonalInfoes.FindAsync(id);
			db.PersonalInfoes.Remove(personalInfo);
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