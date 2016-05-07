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
	public class ProjectController : Controller
	{
		private readonly ApplicationDbContext db = new ApplicationDbContext();

		// GET: Administration/Project
		public async Task<ActionResult> Index()
		{
			return View(await db.Projects.ToListAsync());
		}

		// GET: Administration/Project/Details/5
		public async Task<ActionResult> Details(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Project project = await db.Projects.FindAsync(id);
			if (project == null)
			{
				return HttpNotFound();
			}
			return View(project);
		}

		// GET: Administration/Project/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: Administration/Project/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Create(
			[Bind(
				Include =
				"Id,RecordStatus,ProjectStatus,Name,Description,Notes,ProjectedStartDate,ProjectedEndDate,EstimatedDuration,StartDate,EndDate,TotalDuration"
				)] Project project)
		{
			if (ModelState.IsValid)
			{
				db.Projects.Add(project);
				await db.SaveChangesAsync();
				return RedirectToAction("Index");
			}

			return View(project);
		}

		// GET: Administration/Project/Edit/5
		public async Task<ActionResult> Edit(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Project project = await db.Projects.FindAsync(id);
			if (project == null)
			{
				return HttpNotFound();
			}
			return View(project);
		}

		// POST: Administration/Project/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Edit(
			[Bind(
				Include =
				"Id,RecordStatus,ProjectStatus,Name,Description,Notes,ProjectedStartDate,ProjectedEndDate,EstimatedDuration,StartDate,EndDate,TotalDuration"
				)] Project project)
		{
			if (ModelState.IsValid)
			{
				db.Entry(project)
				.State = EntityState.Modified;
				await db.SaveChangesAsync();
				return RedirectToAction("Index");
			}
			return View(project);
		}

		// GET: Administration/Project/Delete/5
		public async Task<ActionResult> Delete(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Project project = await db.Projects.FindAsync(id);
			if (project == null)
			{
				return HttpNotFound();
			}
			return View(project);
		}

		// POST: Administration/Project/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> DeleteConfirmed(long id)
		{
			Project project = await db.Projects.FindAsync(id);
			db.Projects.Remove(project);
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