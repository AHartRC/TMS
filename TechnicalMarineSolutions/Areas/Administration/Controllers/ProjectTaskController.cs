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
	public class ProjectTaskController : Controller
	{
		private readonly ApplicationDbContext db = new ApplicationDbContext();

		// GET: Administration/ProjectTask
		public async Task<ActionResult> Index()
		{
			var projectTasks = db.ProjectTasks.Include(p => p.Project)
								.Include(p => p.Task);
			return View(await projectTasks.ToListAsync());
		}

		// GET: Administration/ProjectTask/Details/5
		public async Task<ActionResult> Details(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			ProjectTask projectTask = await db.ProjectTasks.FindAsync(id);
			if (projectTask == null)
			{
				return HttpNotFound();
			}
			return View(projectTask);
		}

		// GET: Administration/ProjectTask/Create
		public ActionResult Create()
		{
			ViewBag.ProjectId = new SelectList(db.Projects, "Id", "Name");
			ViewBag.TaskId = new SelectList(db.Tasks, "Id", "Name");
			return View();
		}

		// POST: Administration/ProjectTask/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Create(
			[Bind(
				Include =
				"Id,ProjectId,TaskId,RecordStatus,TaskStatus,Difficulty,EstimatedDuration,TotalDuration,StartTime,EndTime,Notes")] ProjectTask projectTask)
		{
			if (ModelState.IsValid)
			{
				db.ProjectTasks.Add(projectTask);
				await db.SaveChangesAsync();
				return RedirectToAction("Index");
			}

			ViewBag.ProjectId = new SelectList(db.Projects, "Id", "Name", projectTask.ProjectId);
			ViewBag.TaskId = new SelectList(db.Tasks, "Id", "Name", projectTask.TaskId);
			return View(projectTask);
		}

		// GET: Administration/ProjectTask/Edit/5
		public async Task<ActionResult> Edit(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			ProjectTask projectTask = await db.ProjectTasks.FindAsync(id);
			if (projectTask == null)
			{
				return HttpNotFound();
			}
			ViewBag.ProjectId = new SelectList(db.Projects, "Id", "Name", projectTask.ProjectId);
			ViewBag.TaskId = new SelectList(db.Tasks, "Id", "Name", projectTask.TaskId);
			return View(projectTask);
		}

		// POST: Administration/ProjectTask/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Edit(
			[Bind(
				Include =
				"Id,ProjectId,TaskId,RecordStatus,TaskStatus,Difficulty,EstimatedDuration,TotalDuration,StartTime,EndTime,Notes")] ProjectTask projectTask)
		{
			if (ModelState.IsValid)
			{
				db.Entry(projectTask)
				.State = EntityState.Modified;
				await db.SaveChangesAsync();
				return RedirectToAction("Index");
			}
			ViewBag.ProjectId = new SelectList(db.Projects, "Id", "Name", projectTask.ProjectId);
			ViewBag.TaskId = new SelectList(db.Tasks, "Id", "Name", projectTask.TaskId);
			return View(projectTask);
		}

		// GET: Administration/ProjectTask/Delete/5
		public async Task<ActionResult> Delete(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			ProjectTask projectTask = await db.ProjectTasks.FindAsync(id);
			if (projectTask == null)
			{
				return HttpNotFound();
			}
			return View(projectTask);
		}

		// POST: Administration/ProjectTask/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> DeleteConfirmed(long id)
		{
			ProjectTask projectTask = await db.ProjectTasks.FindAsync(id);
			db.ProjectTasks.Remove(projectTask);
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