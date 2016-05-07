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
	public class TaskImageController : Controller
	{
		private readonly ApplicationDbContext db = new ApplicationDbContext();

		// GET: Administration/TaskImage
		public async Task<ActionResult> Index()
		{
			var taskImages = db.TaskImages.Include(t => t.Task);
			return View(await taskImages.ToListAsync());
		}

		// GET: Administration/TaskImage/Details/5
		public async Task<ActionResult> Details(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			TaskImage taskImage = await db.TaskImages.FindAsync(id);
			if (taskImage == null)
			{
				return HttpNotFound();
			}
			return View(taskImage);
		}

		// GET: Administration/TaskImage/Create
		public ActionResult Create()
		{
			ViewBag.TaskId = new SelectList(db.Tasks, "Id", "Name");
			return View();
		}

		// POST: Administration/TaskImage/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Create(
			[Bind(Include = "Id,TaskId,RecordStatus,ImageStatus,Width,Height,Source,AltText,Name,Author,Description,Notes")] TaskImage taskImage)
		{
			if (ModelState.IsValid)
			{
				db.TaskImages.Add(taskImage);
				await db.SaveChangesAsync();
				return RedirectToAction("Index");
			}

			ViewBag.TaskId = new SelectList(db.Tasks, "Id", "Name", taskImage.TaskId);
			return View(taskImage);
		}

		// GET: Administration/TaskImage/Edit/5
		public async Task<ActionResult> Edit(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			TaskImage taskImage = await db.TaskImages.FindAsync(id);
			if (taskImage == null)
			{
				return HttpNotFound();
			}
			ViewBag.TaskId = new SelectList(db.Tasks, "Id", "Name", taskImage.TaskId);
			return View(taskImage);
		}

		// POST: Administration/TaskImage/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Edit(
			[Bind(Include = "Id,TaskId,RecordStatus,ImageStatus,Width,Height,Source,AltText,Name,Author,Description,Notes")] TaskImage taskImage)
		{
			if (ModelState.IsValid)
			{
				db.Entry(taskImage)
				.State = EntityState.Modified;
				await db.SaveChangesAsync();
				return RedirectToAction("Index");
			}
			ViewBag.TaskId = new SelectList(db.Tasks, "Id", "Name", taskImage.TaskId);
			return View(taskImage);
		}

		// GET: Administration/TaskImage/Delete/5
		public async Task<ActionResult> Delete(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			TaskImage taskImage = await db.TaskImages.FindAsync(id);
			if (taskImage == null)
			{
				return HttpNotFound();
			}
			return View(taskImage);
		}

		// POST: Administration/TaskImage/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> DeleteConfirmed(long id)
		{
			TaskImage taskImage = await db.TaskImages.FindAsync(id);
			db.TaskImages.Remove(taskImage);
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