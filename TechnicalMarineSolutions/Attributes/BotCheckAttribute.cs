namespace TechnicalMarineSolutions.Attributes
{
	#region Library Imports

	using System.Web.Mvc;

	#endregion

	public class BotCheckAttribute : ActionFilterAttribute
	{
		private const string BOTCHECK_KEY = "BotCheck";

		public override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			string botValue = filterContext.HttpContext.Request.Form[BOTCHECK_KEY].Trim();
			bool botDetected;
			if (bool.TryParse(botValue, out botDetected))
			{
				filterContext.ActionParameters["BotDetected"] = botDetected;
				if (botDetected)
				{
					filterContext.Controller.ViewData.ModelState.AddModelError("botCheck",
																			   "The form has been submitted too quickly.");
					filterContext.Controller.ViewData.ModelState.AddModelError("botCheck",
																			   "Timers have been put in place to prevent automated bots from maliciously accessing the site.");
					filterContext.Controller.ViewData.ModelState.AddModelError("botCheck",
																			   "This and any future detections will be logged and any excessive submissions will result in an IP ban.");
					filterContext.Controller.ViewData.ModelState.AddModelError("botCheck",
																			   "If enough IP addresses from a single subnet are banned, the entire subnet will be banned.");
					// TODO: CHECK FOR EXCESSIVE BOT DETECTIONS AND BAN THE IP/SUBNET IF NECESSARY!
				}
			}
			base.OnActionExecuting(filterContext);
		}
	}
}