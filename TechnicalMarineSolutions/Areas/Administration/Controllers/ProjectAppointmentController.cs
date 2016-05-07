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
	public class ProjectAppointmentController : Controller
	{
		private readonly ApplicationDbContext db = new ApplicationDbContext();

		// GET: Administration/ProjectAppointment
		public async Task<ActionResult> Index()
		{
			var projectAppointments = db.ProjectAppointments.Include(p => p.Appointment)
										.Include(p => p.Project);
			return View(await projectAppointments.ToListAsync());
		}

		// GET: Administration/ProjectAppointment/Details/5
		public async Task<ActionResult> Details(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			ProjectAppointment projectAppointment = await db.ProjectAppointments.FindAsync(id);
			if (projectAppointment == null)
			{
				return HttpNotFound();
			}
			return View(projectAppointment);
		}

		// GET: Administration/ProjectAppointment/Create
		public ActionResult Create()
		{
			ViewBag.AppointmentId = new SelectList(db.Appointments, "Id", "Name");
			ViewBag.ProjectId = new SelectList(db.Projects, "Id", "Name");
			return View();
		}

		// POST: Administration/ProjectAppointment/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Create(
			[Bind(Include = "Id,ProjectId,AppointmentId,RecordStatus,Notes")] ProjectAppointment projectAppointment)
		{
			if (ModelState.IsValid)
			{
				db.ProjectAppointments.Add(projectAppointment);
				await db.SaveChangesAsync();
				return RedirectToAction("Index");
			}

			ViewBag.AppointmentId = new SelectList(db.Appointments, "Id", "Name", projectAppointment.AppointmentId);
			ViewBag.ProjectId = new SelectList(db.Projects, "Id", "Name", projectAppointment.ProjectId);
			return View(projectAppointment);
		}

		// GET: Administration/ProjectAppointment/Edit/5
		public async Task<ActionResult> Edit(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			ProjectAppointment projectAppointment = await db.ProjectAppointments.FindAsync(id);
			if (projectAppointment == null)
			{
				return HttpNotFound();
			}
			ViewBag.AppointmentId = new SelectList(db.Appointments, "Id", "Name", projectAppointment.AppointmentId);
			ViewBag.ProjectId = new SelectList(db.Projects, "Id", "Name", projectAppointment.ProjectId);
			return View(projectAppointment);
		}

		// POST: Administration/ProjectAppointment/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Edit(
			[Bind(Include = "Id,ProjectId,AppointmentId,RecordStatus,Notes")] ProjectAppointment projectAppointment)
		{
			if (ModelState.IsValid)
			{
				db.Entry(projectAppointment)
				.State = EntityState.Modified;
				await db.SaveChangesAsync();
				return RedirectToAction("Index");
			}
			ViewBag.AppointmentId = new SelectList(db.Appointments, "Id", "Name", projectAppointment.AppointmentId);
			ViewBag.ProjectId = new SelectList(db.Projects, "Id", "Name", projectAppointment.ProjectId);
			return View(projectAppointment);
		}

		// GET: Administration/ProjectAppointment/Delete/5
		public async Task<ActionResult> Delete(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			ProjectAppointment projectAppointment = await db.ProjectAppointments.FindAsync(id);
			if (projectAppointment == null)
			{
				return HttpNotFound();
			}
			return View(projectAppointment);
		}

		// POST: Administration/ProjectAppointment/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> DeleteConfirmed(long id)
		{
			ProjectAppointment projectAppointment = await db.ProjectAppointments.FindAsync(id);
			db.ProjectAppointments.Remove(projectAppointment);
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