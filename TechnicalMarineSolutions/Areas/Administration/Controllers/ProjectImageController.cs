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
	public class ProjectImageController : Controller
	{
		private readonly ApplicationDbContext db = new ApplicationDbContext();

		// GET: Administration/ProjectImage
		public async Task<ActionResult> Index()
		{
			var projectImages = db.ProjectImages.Include(p => p.Project);
			return View(await projectImages.ToListAsync());
		}

		// GET: Administration/ProjectImage/Details/5
		public async Task<ActionResult> Details(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			ProjectImage projectImage = await db.ProjectImages.FindAsync(id);
			if (projectImage == null)
			{
				return HttpNotFound();
			}
			return View(projectImage);
		}

		// GET: Administration/ProjectImage/Create
		public ActionResult Create()
		{
			ViewBag.ProjectId = new SelectList(db.Projects, "Id", "Name");
			return View();
		}

		// POST: Administration/ProjectImage/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Create(
			[Bind(Include = "Id,ProjectId,RecordStatus,ImageStatus,Width,Height,Source,AltText,Name,Author,Description,Notes")] ProjectImage projectImage)
		{
			if (ModelState.IsValid)
			{
				db.ProjectImages.Add(projectImage);
				await db.SaveChangesAsync();
				return RedirectToAction("Index");
			}

			ViewBag.ProjectId = new SelectList(db.Projects, "Id", "Name", projectImage.ProjectId);
			return View(projectImage);
		}

		// GET: Administration/ProjectImage/Edit/5
		public async Task<ActionResult> Edit(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			ProjectImage projectImage = await db.ProjectImages.FindAsync(id);
			if (projectImage == null)
			{
				return HttpNotFound();
			}
			ViewBag.ProjectId = new SelectList(db.Projects, "Id", "Name", projectImage.ProjectId);
			return View(projectImage);
		}

		// POST: Administration/ProjectImage/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Edit(
			[Bind(Include = "Id,ProjectId,RecordStatus,ImageStatus,Width,Height,Source,AltText,Name,Author,Description,Notes")] ProjectImage projectImage)
		{
			if (ModelState.IsValid)
			{
				db.Entry(projectImage)
				.State = EntityState.Modified;
				await db.SaveChangesAsync();
				return RedirectToAction("Index");
			}
			ViewBag.ProjectId = new SelectList(db.Projects, "Id", "Name", projectImage.ProjectId);
			return View(projectImage);
		}

		// GET: Administration/ProjectImage/Delete/5
		public async Task<ActionResult> Delete(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			ProjectImage projectImage = await db.ProjectImages.FindAsync(id);
			if (projectImage == null)
			{
				return HttpNotFound();
			}
			return View(projectImage);
		}

		// POST: Administration/ProjectImage/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> DeleteConfirmed(long id)
		{
			ProjectImage projectImage = await db.ProjectImages.FindAsync(id);
			db.ProjectImages.Remove(projectImage);
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