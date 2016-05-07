#region Library Imports

using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using TechnicalMarineSolutions.Models.Context;
using Task = TechnicalMarineSolutions.Models.Binding.Task;

#endregion

namespace TechnicalMarineSolutions.Areas.Administration.Controllers
{
	public class TaskController : Controller
	{
		private readonly ApplicationDbContext _db = new ApplicationDbContext();

		// GET: Administration/Task
		public async Task<ActionResult> Index()
		{
			return View(await _db.Tasks.ToListAsync());
		}

		// GET: Administration/Task/Details/5
		public async Task<ActionResult> Details(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Task task = await _db.Tasks.FindAsync(id);
			if (task == null)
			{
				return HttpNotFound();
			}
			return View(task);
		}

		// GET: Administration/Task/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: Administration/Task/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Create(
			[Bind(Include = "Id,RecordStatus,Difficulty,EstimatedDuration,Name,Description,Notes")] Task task)
		{
			if (ModelState.IsValid)
			{
				_db.Tasks.Add(task);
				await _db.SaveChangesAsync();
				return RedirectToAction("Index");
			}

			return View(task);
		}

		// GET: Administration/Task/Edit/5
		public async Task<ActionResult> Edit(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Task task = await _db.Tasks.FindAsync(id);
			if (task == null)
			{
				return HttpNotFound();
			}
			return View(task);
		}

		// POST: Administration/Task/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Edit(
			[Bind(Include = "Id,RecordStatus,Difficulty,EstimatedDuration,Name,Description,Notes")] Task task)
		{
			if (ModelState.IsValid)
			{
				_db.Entry(task)
					.State = EntityState.Modified;
				await _db.SaveChangesAsync();
				return RedirectToAction("Index");
			}
			return View(task);
		}

		// GET: Administration/Task/Delete/5
		public async Task<ActionResult> Delete(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Task task = await _db.Tasks.FindAsync(id);
			if (task == null)
			{
				return HttpNotFound();
			}
			return View(task);
		}

		// POST: Administration/Task/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> DeleteConfirmed(long id)
		{
			Task task = await _db.Tasks.FindAsync(id);
			_db.Tasks.Remove(task);
			await _db.SaveChangesAsync();
			return RedirectToAction("Index");
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				_db.Dispose();
			}
			base.Dispose(disposing);
		}
	}
}