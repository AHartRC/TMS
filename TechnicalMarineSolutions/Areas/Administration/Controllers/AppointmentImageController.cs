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
	public class AppointmentImageController : Controller
	{
		private readonly ApplicationDbContext db = new ApplicationDbContext();

		// GET: Administration/AppointmentImage
		public async Task<ActionResult> Index()
		{
			var appointmentImages = db.AppointmentImages.Include(a => a.Appointment);
			return View(await appointmentImages.ToListAsync());
		}

		// GET: Administration/AppointmentImage/Details/5
		public async Task<ActionResult> Details(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			AppointmentImage appointmentImage = await db.AppointmentImages.FindAsync(id);
			if (appointmentImage == null)
			{
				return HttpNotFound();
			}
			return View(appointmentImage);
		}

		// GET: Administration/AppointmentImage/Create
		public ActionResult Create()
		{
			ViewBag.AppointmentId = new SelectList(db.Appointments, "Id", "Name");
			return View();
		}

		// POST: Administration/AppointmentImage/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Create(
			[Bind(Include = "Id,AppointmentId,RecordStatus,ImageStatus,Width,Height,Source,AltText,Name,Author,Description,Notes"
				)] AppointmentImage appointmentImage)
		{
			if (ModelState.IsValid)
			{
				db.AppointmentImages.Add(appointmentImage);
				await db.SaveChangesAsync();
				return RedirectToAction("Index");
			}

			ViewBag.AppointmentId = new SelectList(db.Appointments, "Id", "Name", appointmentImage.AppointmentId);
			return View(appointmentImage);
		}

		// GET: Administration/AppointmentImage/Edit/5
		public async Task<ActionResult> Edit(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			AppointmentImage appointmentImage = await db.AppointmentImages.FindAsync(id);
			if (appointmentImage == null)
			{
				return HttpNotFound();
			}
			ViewBag.AppointmentId = new SelectList(db.Appointments, "Id", "Name", appointmentImage.AppointmentId);
			return View(appointmentImage);
		}

		// POST: Administration/AppointmentImage/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Edit(
			[Bind(Include = "Id,AppointmentId,RecordStatus,ImageStatus,Width,Height,Source,AltText,Name,Author,Description,Notes"
				)] AppointmentImage appointmentImage)
		{
			if (ModelState.IsValid)
			{
				db.Entry(appointmentImage)
				.State = EntityState.Modified;
				await db.SaveChangesAsync();
				return RedirectToAction("Index");
			}
			ViewBag.AppointmentId = new SelectList(db.Appointments, "Id", "Name", appointmentImage.AppointmentId);
			return View(appointmentImage);
		}

		// GET: Administration/AppointmentImage/Delete/5
		public async Task<ActionResult> Delete(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			AppointmentImage appointmentImage = await db.AppointmentImages.FindAsync(id);
			if (appointmentImage == null)
			{
				return HttpNotFound();
			}
			return View(appointmentImage);
		}

		// POST: Administration/AppointmentImage/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> DeleteConfirmed(long id)
		{
			AppointmentImage appointmentImage = await db.AppointmentImages.FindAsync(id);
			db.AppointmentImages.Remove(appointmentImage);
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