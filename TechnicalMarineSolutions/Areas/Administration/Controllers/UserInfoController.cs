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
	public class UserInfoController : Controller
	{
		private readonly ApplicationDbContext db = new ApplicationDbContext();

		// GET: Administration/UserInfo
		public async Task<ActionResult> Index()
		{
			var userInfoes = db.UserInfoes.Include(u => u.User);
			return View(await userInfoes.ToListAsync());
		}

		// GET: Administration/UserInfo/Details/5
		public async Task<ActionResult> Details(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			User userInfo = await db.UserInfoes.FindAsync(id);
			if (userInfo == null)
			{
				return HttpNotFound();
			}
			return View(userInfo);
		}

		// GET: Administration/UserInfo/Create
		public ActionResult Create()
		{
			ViewBag.UserId = new SelectList(db.Users, "Id", "Email");
			return View();
		}

		// POST: Administration/UserInfo/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Create([Bind(Include = "Id,UserId,DisplayName")] User userInfo)
		{
			if (ModelState.IsValid)
			{
				db.UserInfoes.Add(userInfo);
				await db.SaveChangesAsync();
				return RedirectToAction("Index");
			}

			ViewBag.UserId = new SelectList(db.Users, "Id", "Email", userInfo.UserId);
			return View(userInfo);
		}

		// GET: Administration/UserInfo/Edit/5
		public async Task<ActionResult> Edit(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			User userInfo = await db.UserInfoes.FindAsync(id);
			if (userInfo == null)
			{
				return HttpNotFound();
			}
			ViewBag.UserId = new SelectList(db.Users, "Id", "Email", userInfo.UserId);
			return View(userInfo);
		}

		// POST: Administration/UserInfo/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Edit([Bind(Include = "Id,UserId,DisplayName")] User userInfo)
		{
			if (ModelState.IsValid)
			{
				db.Entry(userInfo)
				.State = EntityState.Modified;
				await db.SaveChangesAsync();
				return RedirectToAction("Index");
			}
			ViewBag.UserId = new SelectList(db.Users, "Id", "Email", userInfo.UserId);
			return View(userInfo);
		}

		// GET: Administration/UserInfo/Delete/5
		public async Task<ActionResult> Delete(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			User userInfo = await db.UserInfoes.FindAsync(id);
			if (userInfo == null)
			{
				return HttpNotFound();
			}
			return View(userInfo);
		}

		// POST: Administration/UserInfo/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> DeleteConfirmed(long id)
		{
			User userInfo = await db.UserInfoes.FindAsync(id);
			db.UserInfoes.Remove(userInfo);
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