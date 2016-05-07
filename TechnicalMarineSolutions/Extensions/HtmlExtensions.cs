#region Library Imports

using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

#endregion

namespace TechnicalMarineSolutions.Extensions
{
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

		public static IHtmlString ImageLink(this HtmlHelper helper, string imgSrc, string alt, string actionName,
											string controllerName, object routeValues = null, object htmlAttributes = null,
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
	}
}