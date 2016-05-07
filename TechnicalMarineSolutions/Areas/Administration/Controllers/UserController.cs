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
	public class UserController : Controller
	{
		private readonly ApplicationDbContext db = new ApplicationDbContext();

		// GET: Administration/User
		public async Task<ActionResult> Index()
		{
			return View(await db.Users.ToListAsync());
		}

		// GET: Administration/User/Details/5
		public async Task<ActionResult> Details(string id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			ApplicationUser applicationUser = await db.Users.FirstOrDefaultAsync(f => f.Id == id);
			if (applicationUser == null)
			{
				return HttpNotFound();
			}
			return View(applicationUser);
		}

		// GET: Administration/User/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: Administration/User/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Create(
			[Bind(
				Include =
				"Id,Email,EmailConfirmed,PasswordHash,SecurityStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEndDateUtc,LockoutEnabled,AccessFailedCount,UserName"
				)] ApplicationUser applicationUser)
		{
			if (ModelState.IsValid)
			{
				db.Users.Add(applicationUser);
				await db.SaveChangesAsync();
				return RedirectToAction("Index");
			}

			return View(applicationUser);
		}

		// GET: Administration/User/Edit/5
		public async Task<ActionResult> Edit(string id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			ApplicationUser applicationUser = await db.Users.FirstOrDefaultAsync(f => f.Id == id);
			if (applicationUser == null)
			{
				return HttpNotFound();
			}
			return View(applicationUser);
		}

		// POST: Administration/User/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Edit(
			[Bind(
				Include =
				"Id,Email,EmailConfirmed,PasswordHash,SecurityStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEndDateUtc,LockoutEnabled,AccessFailedCount,UserName"
				)] ApplicationUser applicationUser)
		{
			if (ModelState.IsValid)
			{
				db.Entry(applicationUser)
				.State = EntityState.Modified;
				await db.SaveChangesAsync();
				return RedirectToAction("Index");
			}
			return View(applicationUser);
		}

		// GET: Administration/User/Delete/5
		public async Task<ActionResult> Delete(string id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			ApplicationUser applicationUser = await db.Users.FirstOrDefaultAsync(f => f.Id == id);
			if (applicationUser == null)
			{
				return HttpNotFound();
			}
			return View(applicationUser);
		}

		// POST: Administration/User/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> DeleteConfirmed(string id)
		{
			ApplicationUser applicationUser = await db.Users.FirstOrDefaultAsync(f => f.Id == id);
			db.Users.Remove(applicationUser);
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