namespace TechnicalMarineSolutions.Extensions
{
	#region Library Imports

	using System.Collections.Generic;
	using System.Configuration;
	using System.Web;
	using System.Web.Mvc;
	using System.Web.Routing;

	#endregion

	public static class HtmlExtensions
	{
		public static IEnumerable<string> Keywords(this HtmlHelper helper)
		{
			return new[]
				   {
					   "Technical Marine Solutions",
					   "Technical",
					   "Marine",
					   "Solutions",
					   "Gregory Davidson",
					   "Gregory",
					   "Greg",
					   "Davidson",
					   "Florida",
					   "Daytona",
					   "Jacksonville",
					   "Miami"
				   };
		}

		public static IHtmlString Image(this HtmlHelper helper, string src, string alt, object imgHtmlAttributes)
		{
			TagBuilder tb = new TagBuilder("img");
			tb.Attributes.Add("src", helper.Encode(src));
			tb.Attributes.Add("alt", helper.Encode(alt));
			tb.MergeAttributes(new RouteValueDictionary(imgHtmlAttributes), true);
			return new MvcHtmlString(tb.ToString(TagRenderMode.SelfClosing));
		}

		public static IHtmlString ImageLink(this HtmlHelper helper,
											string imgSrc,
											string alt,
											string actionName,
											string controllerName,
											object routeValues = null,
											object htmlAttributes = null,
											object imgHtmlAttributes = null)
		{
			UrlHelper urlHelper = ((Controller) helper.ViewContext.Controller).Url;
			string imgtag = helper.Image(imgSrc, alt, imgHtmlAttributes)
								  .ToHtmlString();
			string url = urlHelper.Action(actionName, controllerName, routeValues);

			TagBuilder imglink = new TagBuilder("a");
			imglink.MergeAttribute("href", url);
			imglink.InnerHtml = imgtag;
			imglink.MergeAttributes(new RouteValueDictionary(htmlAttributes), true);
			return new MvcHtmlString(imglink.ToString());
		}

		/// <summary>Returns a Google reCaptcha element for human verification</summary>
		/// <param name="helper">The current HTML extensions helper (Ignore this parameter! SELF INCLUDED!)</param>
		/// <returns>The Google reCaptcha element</returns>
		public static MvcHtmlString Captcha(this HtmlHelper helper)
		{
			TagBuilder tb = new TagBuilder("div");
			tb.Attributes.Add("class", "g-recaptcha");
			tb.Attributes.Add("data-sitekey", ConfigurationManager.AppSettings["RecaptchaKey"]);
			tb.Attributes.Add("data-theme", "dark");
			tb.Attributes.Add("data-type", "image");
			tb.Attributes.Add("data-size", "compact");
			tb.Attributes.Add("data-callback", "reCaptchaCallback");
			tb.Attributes.Add("data-expired-callback", "reCaptchaExpired");
			return new MvcHtmlString(tb.ToString());
		}

		/// <summary>Returns a Google Adsense element</summary>
		/// <param name="helper">The current HTML extensions helper (Ignore this parameter! SELF INCLUDED!)</param>
		/// <returns>The Google Adsense element to be triggered via javascript</returns>
		public static MvcHtmlString GoogleAdsense(this HtmlHelper helper)
		{
			const string rawString =
				"<p class=\"text-muted\" style=\"margin: 0 auto;\">Advertisement</p><div class=\"adContainer\" data-istext=\"false\" data-isvertical=\"false\"></div>";
			return MvcHtmlString.Create(rawString);
		}

		/// <summary>Returns a progress bar for use in form timeouts</summary>
		/// <param name="helper">The current HTML extensions helper (Ignore this parameter! SELF INCLUDED!)</param>
		/// <param name="currentVal">The current value of the progress bar</param>
		/// <param name="minVal">The minimum value of the progress bar</param>
		/// <param name="maxVal">The maximum value of the progress bar</param>
		/// <param name="steps">The total number of steps for the progress bar to take</param>
		/// <param name="time">The total amount of time to take</param>
		/// <returns>The progress bar as an MvcHtmlString</returns>
		public static MvcHtmlString FormProgress(this HtmlHelper helper,
												 float currentVal,
												 int minVal,
												 int maxVal,
												 int steps,
												 int time)
		{
			const string rawString =
				"<div class=\"progress progress-striped active\">"
				+ "<div class=\"progress-bar progress-bar-info\" role=\"progressbar\" aria-valuenow=\"{0}\" aria-valuemin=\"{1}\" aria-valuemax=\"{2}\" data-totalsteps=\"{3}\" data-time=\"{4}\" style=\"width: {0}%;\">"
				+ "<div id=\"submitMessage\"></div>" + "</div>" + "</div>";
			return MvcHtmlString.Create(string.Format(rawString, currentVal, minVal, maxVal, steps, time));
		}

		/// <summary>Returns a submit button</summary>
		/// <param name="helper">The current HTML extensions helper (Ignore this parameter! SELF INCLUDED!)</param>
		/// <param name="text">The text caption of the button</param>
		/// <param name="isBlock">
		///     Whether or not the button is a block element that takes the entire width of the parent container
		///     (Optional)
		/// </param>
		/// <returns>The button as an MvcHtmlString</returns>
		public static MvcHtmlString SubmitButton(this HtmlHelper helper, string text, bool isBlock = true)
		{
			const string rawString = "<button class=\"btn btn-lg btn-primary{1}\" type=\"submit\">{0}</button>";
			return MvcHtmlString.Create(string.Format(rawString,
													  text,
													  isBlock
														  ? " btn-block"
														  : ""));
		}

		public static MvcHtmlString BotCheck(this HtmlHelper helper,
											 float currentVal,
											 int minVal,
											 int maxVal,
											 int steps,
											 int time,
											 string buttonText,
											 bool isBlock = true)
		{
			const string rawString =
				"<input name=\"BotCheck\" id=\"BotCheck\" type=\"hidden\" value=\"True\"></input>"
				+ "<button class=\"btn btn-lg btn-primary{0}\" type=\"submit\">{1}</button>"
				+ "<div class=\"progress progress-striped active\">"
				+ "<div class=\"progress-bar progress-bar-info\" role=\"progressbar\" aria-valuenow=\"{2}\" aria-valuemin=\"{3}\" aria-valuemax=\"{4}\" data-totalsteps=\"{5}\" data-time=\"{6}\" style=\"width: {1}%;\">"
				+ "<div id=\"submitMessage\"></div>" + "</div>" + "</div>"
				+ "<input class=\"btn btn-xs btn-primary text-center resetTimer\" type=\"button\" value=\"Reset Timer(s)\" />";
			return MvcHtmlString.Create(string.Format(rawString,
													  isBlock
														  ? " btn-block"
														  : "",
													  buttonText,
													  currentVal,
													  maxVal,
													  maxVal,
													  steps,
													  time));
		}
	}
}