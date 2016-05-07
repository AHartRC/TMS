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
	public class AppointmentTaskController : Controller
	{
		private readonly ApplicationDbContext db = new ApplicationDbContext();

		// GET: Administration/AppointmentTask
		public async Task<ActionResult> Index()
		{
			var appointmentTasks = db.AppointmentTasks.Include(a => a.Appointment)
									.Include(a => a.Task);
			return View(await appointmentTasks.ToListAsync());
		}

		// GET: Administration/AppointmentTask/Details/5
		public async Task<ActionResult> Details(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			AppointmentTask appointmentTask = await db.AppointmentTasks.FindAsync(id);
			if (appointmentTask == null)
			{
				return HttpNotFound();
			}
			return View(appointmentTask);
		}

		// GET: Administration/AppointmentTask/Create
		public ActionResult Create()
		{
			ViewBag.AppointmentId = new SelectList(db.Appointments, "Id", "Name");
			ViewBag.TaskId = new SelectList(db.Tasks, "Id", "Name");
			return View();
		}

		// POST: Administration/AppointmentTask/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Create(
			[Bind(
				Include =
				"Id,AppointmentId,TaskId,RecordStatus,TaskStatus,Difficulty,EstimatedDuration,TotalDuration,StartTime,EndTime,Notes"
				)] AppointmentTask appointmentTask)
		{
			if (ModelState.IsValid)
			{
				db.AppointmentTasks.Add(appointmentTask);
				await db.SaveChangesAsync();
				return RedirectToAction("Index");
			}

			ViewBag.AppointmentId = new SelectList(db.Appointments, "Id", "Name", appointmentTask.AppointmentId);
			ViewBag.TaskId = new SelectList(db.Tasks, "Id", "Name", appointmentTask.TaskId);
			return View(appointmentTask);
		}

		// GET: Administration/AppointmentTask/Edit/5
		public async Task<ActionResult> Edit(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			AppointmentTask appointmentTask = await db.AppointmentTasks.FindAsync(id);
			if (appointmentTask == null)
			{
				return HttpNotFound();
			}
			ViewBag.AppointmentId = new SelectList(db.Appointments, "Id", "Name", appointmentTask.AppointmentId);
			ViewBag.TaskId = new SelectList(db.Tasks, "Id", "Name", appointmentTask.TaskId);
			return View(appointmentTask);
		}

		// POST: Administration/AppointmentTask/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Edit(
			[Bind(
				Include =
				"Id,AppointmentId,TaskId,RecordStatus,TaskStatus,Difficulty,EstimatedDuration,TotalDuration,StartTime,EndTime,Notes"
				)] AppointmentTask appointmentTask)
		{
			if (ModelState.IsValid)
			{
				db.Entry(appointmentTask)
				.State = EntityState.Modified;
				await db.SaveChangesAsync();
				return RedirectToAction("Index");
			}
			ViewBag.AppointmentId = new SelectList(db.Appointments, "Id", "Name", appointmentTask.AppointmentId);
			ViewBag.TaskId = new SelectList(db.Tasks, "Id", "Name", appointmentTask.TaskId);
			return View(appointmentTask);
		}

		// GET: Administration/AppointmentTask/Delete/5
		public async Task<ActionResult> Delete(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			AppointmentTask appointmentTask = await db.AppointmentTasks.FindAsync(id);
			if (appointmentTask == null)
			{
				return HttpNotFound();
			}
			return View(appointmentTask);
		}

		// POST: Administration/AppointmentTask/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> DeleteConfirmed(long id)
		{
			AppointmentTask appointmentTask = await db.AppointmentTasks.FindAsync(id);
			db.AppointmentTasks.Remove(appointmentTask);
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