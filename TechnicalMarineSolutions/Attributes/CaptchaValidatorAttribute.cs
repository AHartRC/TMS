namespace TechnicalMarineSolutions.Attributes
{
	#region Library Imports

	using System.Configuration;
	using System.Diagnostics;
	using System.Net;
	using System.Web.Mvc;
	using Newtonsoft.Json;
	using UrlHelper = TechnicalMarineSolutions.Helpers.UrlHelper;

	#endregion

	public class CaptchaValidatorAttribute : ActionFilterAttribute
	{
		private const string CHALLENGE_FIELD_KEY = "recaptcha_challenge_field";

		private const string RESPONSE_FIELD_KEY = "g-recaptcha-response";

		public override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			string captchaResponseValue = filterContext.HttpContext.Request.Form[RESPONSE_FIELD_KEY];

			if (string.IsNullOrWhiteSpace(captchaResponseValue))
				captchaResponseValue = "FALSE";

			//string response = Traffic.Http($"{Helpers.UrlHelper.googleRecaptchaVerify}secret={ConfigurationManager.AppSettings["RecaptchaSecret"]}&response={captchaResponseValue}&remoteip={filterContext.HttpContext.Request.UserHostAddress}", "POST", null);
			WebClient client = new WebClient();
			string response =
				client.DownloadString(
									  $"{UrlHelper.googleRecaptchaVerify}?secret={ConfigurationManager.AppSettings["RecaptchaSecret"]}&response={captchaResponseValue}&remoteip={filterContext.HttpContext.Request.UserHostAddress}");

			Debug.WriteLine(response);

			dynamic result = JsonConvert.DeserializeObject(response);

			if (!(bool) result["success"]) // If invalid, add error to the model state to be displayed with validation!
			{
				filterContext.Controller.ViewData.ModelState.AddModelError("reCaptcha",
																		   "The response to the captcha is invalid. Please try again!");
			}

			// this will push the result value into a parameter in our Action  
			filterContext.ActionParameters["captchaResponse"] = response;
			base.OnActionExecuting(filterContext);
		}
	}
}