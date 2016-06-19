namespace TechnicalMarineSolutions.Controllers
{
	#region Library Imports

	using System;
	using System.Web.Mvc;
	using Elmah;
	using Microsoft.AspNet.Identity;
	using TechnicalMarineSolutions.Attributes;
	using TechnicalMarineSolutions.Models.Base;
	using TechnicalMarineSolutions.Models.Binding;
	using TechnicalMarineSolutions.Models.Context;

	#endregion

	[ElmahHandleError]
	public class BaseController : Controller
	{
		protected ApplicationDbContext Db = new ApplicationDbContext();

		protected Guid CurrentUserId => Guid.Parse(User.Identity.GetUserId());

		protected User CurrentUser => Db.Users.Find(CurrentUserId);

		protected bool IsAnonymous => CurrentUser == null;

		protected bool IsModelValid => ModelState.IsValid;

		public static bool IsDebug
		{
			get
			{
#if DEBUG
				return true;
#else
				return false;
#endif
			}
		}

		protected override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			LogVisit(filterContext);
			base.OnActionExecuting(filterContext);
		}

		protected static void LogVisit(ActionExecutingContext filterContext)
		{
			ClientInfo clientInfo = new ClientInfo(filterContext.HttpContext.Request);
			if (clientInfo == null)
				throw new Exception();
		}

		public static void LogError(Exception e, string message = null)
		{
			if (!string.IsNullOrWhiteSpace(message))
			{
				Exception ex = new Exception(message, e);
				ErrorSignal.FromCurrentContext().Raise(ex);
			}
			else
				ErrorSignal.FromCurrentContext().Raise(e);
		}

		protected ActionResult RedirectToLocal(string returnUrl)
		{
			return Url.IsLocalUrl(returnUrl)
					   ? (ActionResult) Redirect(returnUrl)
					   : RedirectToAction("Index",
										  "Home",
										  new
										  {
											  area = ""
										  });
		}
	}
}