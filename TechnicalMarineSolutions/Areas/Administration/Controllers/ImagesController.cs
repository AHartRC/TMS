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
	public class ImagesController : Controller
	{
		private readonly ApplicationDbContext db = new ApplicationDbContext();

		// GET: Administration/Images
		public async Task<ActionResult> Index()
		{
			return View(await db.Images.ToListAsync());
		}

		// GET: Administration/Images/Details/5
		public async Task<ActionResult> Details(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Image image = await db.Images.FindAsync(id);
			if (image == null)
			{
				return HttpNotFound();
			}
			return View(image);
		}

		// GET: Administration/Images/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: Administration/Images/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Create(
			[Bind(
				Include =
				"Id,EntityTypeId,EntityId,RecordStatus,ImageStatus,Width,Height,Source,AltText,Name,Author,Description,Notes")] Image image)
		{
			if (ModelState.IsValid)
			{
				db.Images.Add(image);
				await db.SaveChangesAsync();
				return RedirectToAction("Index");
			}

			return View(image);
		}

		// GET: Administration/Images/Edit/5
		public async Task<ActionResult> Edit(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Image image = await db.Images.FindAsync(id);
			if (image == null)
			{
				return HttpNotFound();
			}
			return View(image);
		}

		// POST: Administration/Images/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Edit(
			[Bind(
				Include =
				"Id,EntityTypeId,EntityId,RecordStatus,ImageStatus,Width,Height,Source,AltText,Name,Author,Description,Notes")] Image image)
		{
			if (ModelState.IsValid)
			{
				db.Entry(image)
				.State = EntityState.Modified;
				await db.SaveChangesAsync();
				return RedirectToAction("Index");
			}
			return View(image);
		}

		// GET: Administration/Images/Delete/5
		public async Task<ActionResult> Delete(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Image image = await db.Images.FindAsync(id);
			if (image == null)
			{
				return HttpNotFound();
			}
			return View(image);
		}

		// POST: Administration/Images/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> DeleteConfirmed(long id)
		{
			Image image = await db.Images.FindAsync(id);
			db.Images.Remove(image);
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