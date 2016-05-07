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
	public class AppointmentController : Controller
	{
		private readonly ApplicationDbContext db = new ApplicationDbContext();

		// GET: Administration/Appointment
		public async Task<ActionResult> Index()
		{
			var appointments = db.Appointments.Include(a => a.PostalAddress);
			return View(await appointments.ToListAsync());
		}

		// GET: Administration/Appointment/Details/5
		public async Task<ActionResult> Details(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Appointment appointment = await db.Appointments.FindAsync(id);
			if (appointment == null)
			{
				return HttpNotFound();
			}
			return View(appointment);
		}

		// GET: Administration/Appointment/Create
		public ActionResult Create()
		{
			ViewBag.PostalAddressId = new SelectList(db.PostalAddresses, "Id", "Recipient");
			return View();
		}

		// POST: Administration/Appointment/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Create(
			[Bind(
				Include =
				"Id,PostalAddressId,RecordStatus,AppointmentStatus,Name,Description,Notes,ScheduledDate,StartDate,EndDate,ScheduledDuration,EstimatedDuration,TotalDuration"
				)] Appointment appointment)
		{
			if (ModelState.IsValid)
			{
				db.Appointments.Add(appointment);
				await db.SaveChangesAsync();
				return RedirectToAction("Index");
			}

			ViewBag.PostalAddressId = new SelectList(db.PostalAddresses, "Id", "Recipient", appointment.PostalAddressId);
			return View(appointment);
		}

		// GET: Administration/Appointment/Edit/5
		public async Task<ActionResult> Edit(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Appointment appointment = await db.Appointments.FindAsync(id);
			if (appointment == null)
			{
				return HttpNotFound();
			}
			ViewBag.PostalAddressId = new SelectList(db.PostalAddresses, "Id", "Recipient", appointment.PostalAddressId);
			return View(appointment);
		}

		// POST: Administration/Appointment/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Edit(
			[Bind(
				Include =
				"Id,PostalAddressId,RecordStatus,AppointmentStatus,Name,Description,Notes,ScheduledDate,StartDate,EndDate,ScheduledDuration,EstimatedDuration,TotalDuration"
				)] Appointment appointment)
		{
			if (ModelState.IsValid)
			{
				db.Entry(appointment)
				.State = EntityState.Modified;
				await db.SaveChangesAsync();
				return RedirectToAction("Index");
			}
			ViewBag.PostalAddressId = new SelectList(db.PostalAddresses, "Id", "Recipient", appointment.PostalAddressId);
			return View(appointment);
		}

		// GET: Administration/Appointment/Delete/5
		public async Task<ActionResult> Delete(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Appointment appointment = await db.Appointments.FindAsync(id);
			if (appointment == null)
			{
				return HttpNotFound();
			}
			return View(appointment);
		}

		// POST: Administration/Appointment/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> DeleteConfirmed(long id)
		{
			Appointment appointment = await db.Appointments.FindAsync(id);
			db.Appointments.Remove(appointment);
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