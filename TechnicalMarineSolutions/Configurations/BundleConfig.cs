#region Library Imports

using System.Web.Optimization;
using TechnicalMarineSolutions.Helpers;

#endregion

namespace TechnicalMarineSolutions.Configurations
{
	public class BundleConfig
	{
		// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
#if DEBUG
			BundleTable.EnableOptimizations = false;
#else
			BundleTable.EnableOptimizations = true;
#endif
			bundles.UseCdn = true;

			bundles.IgnoreList.Ignore("_references.js");
			bundles.IgnoreList.Ignore("*.vsdoc.js");
			bundles.IgnoreList.Ignore("*.intellisense.js");
			bundles.IgnoreList.Ignore("*.map");

			#region Scripts

			#region Analytics

			bundles.Add(new ScriptBundle("~/bundles/appinsight").Include("~/Scripts/ai.0.15.0-build58334.*"));
			bundles.Add(new ScriptBundle("~/bundles/googleadsense", UrlHelper.googleAdSenseJS));
			bundles.Add(new ScriptBundle("~/bundles/googleanalytics").Include("~/Scripts/googleanalytics.*"));

			#endregion Analytics

			#region Html5Shiv

			bundles.Add(new ScriptBundle("~/bundles/html5shiv", UrlHelper.html5ShivJS).Include("~/Scripts/html5shiv.*"));
			bundles.Add(
						 new ScriptBundle("~/bundles/html5shiv-print", UrlHelper.html5ShivPrintShivJS).Include(
																											 "~/Scripts/html5shiv-printshiv.*"));

			#endregion Html5Shiv

			#region Respond

			bundles.Add(new ScriptBundle("~/bundles/respond", UrlHelper.respondJS).Include("~/Scripts/respond.*"));
			bundles.Add(
						 new ScriptBundle("~/bundles/respond-listener", UrlHelper.respondJS).Include(
																									 "~/Scripts/respond-matchmedia-addListener.*"));

			#endregion Respond

			#region JQuery

			bundles.Add(
						 new ScriptBundle("~/bundles/jquery1x", UrlHelper.jquery1xJS).Include(
																							 $"~/Scripts/jquery-{UrlHelper.jquery1xVersion}.*"));
			bundles.Add(
						 new ScriptBundle("~/bundles/jquery2x", UrlHelper.jquery2xJS).Include(
																							 $"~/Scripts/jquery-{UrlHelper.jquery2xVersion}.*"));
			bundles.Add(
						 new ScriptBundle("~/bundles/jquerymigrate", UrlHelper.jqueryMigrateJS).Include(
																										 $"~/Scripts/jquery-migrate-{UrlHelper.jqueryMigrateVersion}.*"));
			bundles.Add(
						 new ScriptBundle("~/bundles/jqueryui", UrlHelper.jqueryUIJS).Include(
																							 $"~/Scripts/jquery-ui-{UrlHelper.jqueryUIVersion}.*"));
			bundles.Add(
						 new ScriptBundle("~/bundles/jquerymobile", UrlHelper.jqueryMobileJS).Include(
																									 $"~/Scripts/jquery.mobile-{UrlHelper.jqueryMobileVersion}.*"));
			bundles.Add(
						 new ScriptBundle("~/bundles/jqueryeasing", UrlHelper.jqueryEasingJS).Include(
																									 $"~/Scripts/jquery.easing.{UrlHelper.jqueryEasingVersion}.*"));
			bundles.Add(
						 new ScriptBundle("~/bundles/jquerymixitup", UrlHelper.jqueryMixItUpJS).Include($"~/Scripts/jquery.mixitup.*"));
			bundles.Add(
						 new ScriptBundle("~/bundles/qunit", UrlHelper.jqueryQUnitJS).Include(
																							 $"~/Scripts/qunit-{UrlHelper.jqueryQUnitVersion}.*"));
			bundles.Add(new ScriptBundle("~/bundles/pep", UrlHelper.jqueryPEPJS).Include("~/Scripts/pep.*"));

			#region Color

			bundles.Add(
						 new ScriptBundle("~/bundles/jquerycolor", UrlHelper.jqueryColorJS).Include(
																									 $"~/Scripts/jquery.color-{UrlHelper.jqueryColorVersion}.*"));
			bundles.Add(
						 new ScriptBundle("~/bundles/jquerycolorsvgnames", UrlHelper.jqueryColorSVGNamesJS).Include(
																													 $"~/Scripts/jquery.color.svg-names-{UrlHelper.jqueryColorVersion}.*"));
			bundles.Add(
						 new ScriptBundle("~/bundles/jquerycolorplusnames", UrlHelper.jqueryColorPlusSVGNamesJS).Include(
																														 $"~/Scripts/jquery.color.plus-names-{UrlHelper.jqueryColorVersion}.*"));

			#endregion Color

			#region Validation

			bundles.Add(
						 new ScriptBundle("~/bundles/jqueryvala", UrlHelper.jqueryValidateJS).Include("~/Scripts/jquery.validate.*"));
			bundles.Add(
						 new ScriptBundle("~/bundles/jqueryvalb", UrlHelper.jqueryValidateAdditionalJS).Include(
																												 "~/Scripts/jquery.validate-additional-methods.*"));
			bundles.Add(
						 new ScriptBundle("~/bundles/jqueryvalc", UrlHelper.jqueryValidateUnobtrusiveJS).Include(
																												 "~/Scripts/jquery.validate-unobtrusive.*"));
			bundles.Add(
						 new ScriptBundle("~/bundles/jqueryvald", UrlHelper.jqueryValidateGlobalizationJS).Include(
																												 "~/Scripts/jquery.validate-globalize.*"));

			#endregion Validation

			#endregion JQuery

			#region Bootstrap

			bundles.Add(new ScriptBundle("~/bundles/bootstrap", UrlHelper.bootstrapJS).Include("~/Scripts/bootstrap.*"));
			bundles.Add(
						 new ScriptBundle("~/bundles/bootstraphover", UrlHelper.bootstrapHoverDropdownJS).Include(
																												 "~/Scripts/bootstrap-hover-dropdown.*"));

			#endregion Bootstrap

			#region CLDR

			bundles.Add(new ScriptBundle("~/bundles/cldr", UrlHelper.cldrJS).Include("~/Scripts/cldr.*"));
			bundles.Add(new ScriptBundle("~/bundles/cldrEvent", UrlHelper.cldrEventJS).Include("~/Scripts/cldr/event.*"));
			bundles.Add(
						 new ScriptBundle("~/bundles/cldrSupplemental", UrlHelper.cldrSupplementalJS).Include(
																											 "~/Scripts/cldr/supplemental.*"));
			bundles.Add(
						 new ScriptBundle("~/bundles/cldrUresolved", UrlHelper.cldrUnresolvedJS).Include("~/Scripts/cldr/unresolved.*"));

			#endregion CLDR

			#region Globalize

			bundles.Add(new ScriptBundle("~/bundles/globalize", UrlHelper.globalizeJS).Include("~/Scripts/globalize.*"));
			bundles.Add(
						 new ScriptBundle("~/bundles/globalizeCurrency", UrlHelper.globalizeCurrencyJS).Include(
																												 "~/Scripts/globalize/currency.*"));
			bundles.Add(
						 new ScriptBundle("~/bundles/globalizeDate", UrlHelper.globalizeDateJS).Include("~/Scripts/globalize/date.*"));
			bundles.Add(
						 new ScriptBundle("~/bundles/globalizeMessage", UrlHelper.globalizeMessageJS).Include(
																											 "~/Scripts/globalize/message.*"));
			bundles.Add(
						 new ScriptBundle("~/bundles/globalizeNumber", UrlHelper.globalizeNumberJS).Include("~/Scripts/globalize/number.*"));
			bundles.Add(
						 new ScriptBundle("~/bundles/globalizePlural", UrlHelper.globalizePluralJS).Include("~/Scripts/globalize/plural.*"));
			bundles.Add(
						 new ScriptBundle("~/bundles/globalizeRelativeTime", UrlHelper.globalizeRelativeTimeJS).Include(
																														 "~/Scripts/globalize/relative-time.*"));

			#endregion Globalize

			#region Globalize Runtime

			bundles.Add(new ScriptBundle("~/bundles/globalizeRuntime", UrlHelper.globalizeRuntimeJS));
			bundles.Add(new ScriptBundle("~/bundles/globalizeRuntimeCurrency", UrlHelper.globalizeRuntimeCurrencyJS));
			bundles.Add(new ScriptBundle("~/bundles/globalizeRuntimeDate", UrlHelper.globalizeRuntimeDateJS));
			bundles.Add(new ScriptBundle("~/bundles/globalizeRuntimeMessage", UrlHelper.globalizeRuntimeMessageJS));
			bundles.Add(new ScriptBundle("~/bundles/globalizeRuntimeNumber", UrlHelper.globalizeRuntimeNumberJS));
			bundles.Add(new ScriptBundle("~/bundles/globalizeRuntimePlural", UrlHelper.globalizeRuntimePluralJS));
			bundles.Add(new ScriptBundle("~/bundles/globalizeRuntimeRelativeTime", UrlHelper.globalizeRuntimeRelativeTimeJS));
			bundles.Add(new ScriptBundle("~/bundles/globalizeRuntimeUnit", UrlHelper.globalizeRuntimeUnitJS));

			#endregion Globalize Runtime

			#region FullCalendar

			bundles.Add(new ScriptBundle("~/bundles/fullCalendar", UrlHelper.fullCalendarJS).Include("~/Scripts/fullcalendar.*"));
			bundles.Add(new ScriptBundle("~/bundles/fullCalendarGCAL", UrlHelper.fullCalendarGCALJS).Include("~/Scripts/gcal.*"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangAll", UrlHelper.fullCalendarLangAllJS).Include(
																													 "~/Scripts/lang-all.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangAR", UrlHelper.fullCalendarLangARJS).Include("~/Scripts/lang/ar.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangARMA", UrlHelper.fullCalendarLangARMAJS).Include(
																													 "~/Scripts/lang/ar-ma.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangARSA", UrlHelper.fullCalendarLangARSAJS).Include(
																													 "~/Scripts/lang/ar-sa.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangARTN", UrlHelper.fullCalendarLangARTNJS).Include(
																													 "~/Scripts/lang/ar-tn.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangBG", UrlHelper.fullCalendarLangBGJS).Include("~/Scripts/lang/bg.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangCA", UrlHelper.fullCalendarLangCAJS).Include("~/Scripts/lang/ca.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangCS", UrlHelper.fullCalendarLangCSJS).Include("~/Scripts/lang/cs.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangDA", UrlHelper.fullCalendarLangDAJS).Include("~/Scripts/lang/da.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangDEAT", UrlHelper.fullCalendarLangDEATJS).Include(
																													 "~/Scripts/lang/de-at.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangDE", UrlHelper.fullCalendarLangDEJS).Include("~/Scripts/lang/de.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangEL", UrlHelper.fullCalendarLangELJS).Include("~/Scripts/lang/el.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangENAU", UrlHelper.fullCalendarLangENAUJS).Include(
																													 "~/Scripts/lang/en-au.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangENCA", UrlHelper.fullCalendarLangENCAJS).Include(
																													 "~/Scripts/lang/en-ca.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangENGB", UrlHelper.fullCalendarLangENGBJS).Include(
																													 "~/Scripts/lang/en-gb.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangENIE", UrlHelper.fullCalendarLangENIEJS).Include(
																													 "~/Scripts/lang/en-ie.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangENNZ", UrlHelper.fullCalendarLangENNZJS).Include(
																													 "~/Scripts/lang/en-nz.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangES", UrlHelper.fullCalendarLangESJS).Include("~/Scripts/lang/es.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangFA", UrlHelper.fullCalendarLangFAJS).Include("~/Scripts/lang/fa.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangFI", UrlHelper.fullCalendarLangFIJS).Include("~/Scripts/lang/fi.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangFRCA", UrlHelper.fullCalendarLangFRCAJS).Include(
																													 "~/Scripts/lang/fr-ca.js"));
			bundles.Add(new ScriptBundle("~/bundles/fullCalendarLangFRCH", UrlHelper.fullCalendarLangFRCHJS));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangFR", UrlHelper.fullCalendarLangFRJS).Include("~/Scripts/lang/fr.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangHE", UrlHelper.fullCalendarLangHEJS).Include("~/Scripts/lang/he.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangHI", UrlHelper.fullCalendarLangHIJS).Include("~/Scripts/lang/hi.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangHR", UrlHelper.fullCalendarLangHRJS).Include("~/Scripts/lang/hr.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangHU", UrlHelper.fullCalendarLangHUJS).Include("~/Scripts/lang/hu.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangID", UrlHelper.fullCalendarLangIDJS).Include("~/Scripts/lang/id.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangIS", UrlHelper.fullCalendarLangISJS).Include("~/Scripts/lang/is.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangIT", UrlHelper.fullCalendarLangITJS).Include("~/Scripts/lang/it.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangJA", UrlHelper.fullCalendarLangJAJS).Include("~/Scripts/lang/ja.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangKO", UrlHelper.fullCalendarLangKOJS).Include("~/Scripts/lang/ko.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangLT", UrlHelper.fullCalendarLangLTJS).Include("~/Scripts/lang/lt.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangLV", UrlHelper.fullCalendarLangLVJS).Include("~/Scripts/lang/lv.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangNB", UrlHelper.fullCalendarLangNBJS).Include("~/Scripts/lang/nb.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangNL", UrlHelper.fullCalendarLangNLJS).Include("~/Scripts/lang/nl.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangPL", UrlHelper.fullCalendarLangPLJS).Include("~/Scripts/lang/pl.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangPTBR", UrlHelper.fullCalendarLangPTBRJS).Include(
																													 "~/Scripts/lang/pt-br.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangPT", UrlHelper.fullCalendarLangPTJS).Include("~/Scripts/lang/pt.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangRO", UrlHelper.fullCalendarLangROJS).Include("~/Scripts/lang/ro.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangRU", UrlHelper.fullCalendarLangRUJS).Include("~/Scripts/lang/ru.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangSK", UrlHelper.fullCalendarLangSKJS).Include("~/Scripts/lang/sk.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangSL", UrlHelper.fullCalendarLangSLJS).Include("~/Scripts/lang/sl.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangSRCYRL", UrlHelper.fullCalendarLangSRCYRLJS).Include(
																														 "~/Scripts/lang/sr-cyrl.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangSR", UrlHelper.fullCalendarLangSRJS).Include("~/Scripts/lang/sr.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangSV", UrlHelper.fullCalendarLangSVJS).Include("~/Scripts/lang/sv.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangTH", UrlHelper.fullCalendarLangTHJS).Include("~/Scripts/lang/th.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangTR", UrlHelper.fullCalendarLangTRJS).Include("~/Scripts/lang/tr.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangUK", UrlHelper.fullCalendarLangUKJS).Include("~/Scripts/lang/uk.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangVI", UrlHelper.fullCalendarLangVIJS).Include("~/Scripts/lang/vi.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangZHCN", UrlHelper.fullCalendarLangZHCNJS).Include(
																													 "~/Scripts/lang/zh-cn.js"));
			bundles.Add(
						 new ScriptBundle("~/bundles/fullCalendarLangZHTW", UrlHelper.fullCalendarLangZHTWJS).Include(
																													 "~/Scripts/lang/zh-tw.js"));

			#endregion FullCalendar

			#region Front-End

			bundles.Add(
						 new ScriptBundle("~/bundles/sammy", UrlHelper.sammyJS).Include($"~/Scripts/sammy-{UrlHelper.sammyVersion}.*"));
			bundles.Add(new ScriptBundle("~/bundles/wow").Include("~/Scripts/wow.*"));
			bundles.Add(new ScriptBundle("~/bundles/toastr", UrlHelper.toastrJS).Include($"~/Scripts/toastr.*"));
			bundles.Add(new ScriptBundle("~/bundles/isotope", UrlHelper.isotopeJS).Include($"~/Scripts/isotope.*"));
			bundles.Add(new ScriptBundle("~/bundles/flexslider", UrlHelper.flexsliderJS).Include($"~/Scripts/jquery.flexslider.*"));
			bundles.Add(new ScriptBundle("~/bundles/themepunch").Include($"~/Scripts/jquery.themepunch.revolution.*",
																		"~/Scripts/jquery.themepunch.tools.*"));

			#endregion Front-End

			bundles.Add(new ScriptBundle("~/bundles/site").Include("~/Scripts/site.*"));

			#endregion

			#region Styles

			bundles.Add(new StyleBundle("~/Content/normalize", UrlHelper.normalizeCSS).Include("~/Content/normalize.*",
																								new CssRewriteUrlTransform()));
			bundles.Add(new StyleBundle("~/Content/jqueryuibase").Include("~/Content/themes/base/all.*",
																		new CssRewriteUrlTransform()));
			bundles.Add(new StyleBundle("~/Content/jqueryuidefault").Include("~/Content/themes/default/jquery-ui.*",
																			new CssRewriteUrlTransform()));

			bundles.Add(
						 new StyleBundle("~/Content/jqueryuiblacktie", UrlHelper.jqueryUIBlackTieCSS).Include(
																											 "~/Content/themes/black-tie/jquery.ui.*", new CssRewriteUrlTransform()));
			bundles.Add(
						 new StyleBundle("~/Content/jqueryuiblitzer", UrlHelper.jqueryUIBlitzerCSS).Include(
																											 "~/Content/themes/blitzer/jquery.ui.*", new CssRewriteUrlTransform()));
			bundles.Add(
						 new StyleBundle("~/Content/jqueryuicupertino", UrlHelper.jqueryUICupertinoCSS).Include(
																												 "~/Content/themes/cupertino/jquery.ui.*", new CssRewriteUrlTransform()));
			bundles.Add(
						 new StyleBundle("~/Content/jqueryuidarkhive", UrlHelper.jqueryUIDarkHiveCSS).Include(
																											 "~/Content/themes/dark-hive/jquery.ui.*", new CssRewriteUrlTransform()));
			bundles.Add(
						 new StyleBundle("~/Content/jqueryuidotluv", UrlHelper.jqueryUIDotLuvCSS).Include(
																										 "~/Content/themes/dot-luv/jquery.ui.*", new CssRewriteUrlTransform()));
			bundles.Add(
						 new StyleBundle("~/Content/jqueryuieggplant", UrlHelper.jqueryUIEggplantCSS).Include(
																											 "~/Content/themes/eggplant/jquery.ui.*", new CssRewriteUrlTransform()));
			bundles.Add(
						 new StyleBundle("~/Content/jqueryuiexcitebike", UrlHelper.jqueryUIExciteBikeCSS).Include(
																												 "~/Content/themes/excite-bike/jquery.ui.*", new CssRewriteUrlTransform()));
			bundles.Add(
						 new StyleBundle("~/Content/jqueryuiflick", UrlHelper.jqueryUIFlickCSS).Include(
																										 "~/Content/themes/flick/jquery.ui.*", new CssRewriteUrlTransform()));
			bundles.Add(
						 new StyleBundle("~/Content/jqueryuihotsneaks", UrlHelper.jqueryUIHotSneaksCSS).Include(
																												 "~/Content/themes/hot-sneaks/jquery.ui.*", new CssRewriteUrlTransform()));
			bundles.Add(
						 new StyleBundle("~/Content/jqueryuihumanity", UrlHelper.jqueryUIHumanityCSS).Include(
																											 "~/Content/themes/humanity/jquery.ui.*", new CssRewriteUrlTransform()));
			bundles.Add(
						 new StyleBundle("~/Content/jqueryuilefrog", UrlHelper.jqueryUILeFrogCSS).Include(
																										 "~/Content/themes/le-frog/jquery.ui.*", new CssRewriteUrlTransform()));
			bundles.Add(
						 new StyleBundle("~/Content/jqueryuimintchocolate", UrlHelper.jqueryUIMintChocolateCSS).Include(
																														 "~/Content/themes/mint-choc/jquery.ui.*", new CssRewriteUrlTransform()));
			bundles.Add(
						 new StyleBundle("~/Content/jqueryuiovercast", UrlHelper.jqueryUIOvercastCSS).Include(
																											 "~/Content/themes/overcast/jquery.ui.*", new CssRewriteUrlTransform()));
			bundles.Add(
						 new StyleBundle("~/Content/jqueryuipeppergrinder", UrlHelper.jqueryUIPepperGrinderCSS).Include(
																														 "~/Content/themes/pepper-grinder/jquery.ui.*", new CssRewriteUrlTransform()));
			bundles.Add(
						 new StyleBundle("~/Content/jqueryuiredmond", UrlHelper.jqueryUIRedmondCSS).Include(
																											 "~/Content/themes/redmond/jquery.ui.*", new CssRewriteUrlTransform()));
			bundles.Add(
						 new StyleBundle("~/Content/jqueryuismoothness", UrlHelper.jqueryUISmoothnessCSS).Include(
																												 "~/Content/themes/smoothness/jquery.ui.*", new CssRewriteUrlTransform()));
			bundles.Add(
						 new StyleBundle("~/Content/jqueryuisouthstreet", UrlHelper.jqueryUISouthStreetCSS).Include(
																													 "~/Content/themes/south-street/jquery.ui.*", new CssRewriteUrlTransform()));
			bundles.Add(
						 new StyleBundle("~/Content/jqueryuistart", UrlHelper.jqueryUIStartCSS).Include(
																										 "~/Content/themes/start/jquery.ui.*", new CssRewriteUrlTransform()));
			bundles.Add(
						 new StyleBundle("~/Content/jqueryuisunny", UrlHelper.jqueryUISunnyCSS).Include(
																										 "~/Content/themes/sunny/jquery.ui.*", new CssRewriteUrlTransform()));
			bundles.Add(
						 new StyleBundle("~/Content/jqueryuiswankypurse", UrlHelper.jqueryUISwankyPurseCSS).Include(
																													 "~/Content/themes/swanky-purse/jquery.ui.*", new CssRewriteUrlTransform()));
			bundles.Add(
						 new StyleBundle("~/Content/jqueryuitrontastic", UrlHelper.jqueryUITrontasticCSS).Include(
																												 "~/Content/themes/trontastic/jquery.ui.*", new CssRewriteUrlTransform()));
			bundles.Add(
						 new StyleBundle("~/Content/jqueryuidarkness", UrlHelper.jqueryUIDarknessCSS).Include(
																											 "~/Content/themes/ui-darkness/jquery.ui.*", new CssRewriteUrlTransform()));
			bundles.Add(
						 new StyleBundle("~/Content/jqueryuilightness", UrlHelper.jqueryUILightnessCSS).Include(
																												 "~/Content/themes/ui-lightness/jquery.ui.*", new CssRewriteUrlTransform()));
			bundles.Add(
						 new StyleBundle("~/Content/jqueryuivader", UrlHelper.jqueryUIVaderCSS).Include(
																										 "~/Content/themes/vader/jquery.ui.*", new CssRewriteUrlTransform()));

			bundles.Add(new StyleBundle("~/Content/jquerymobile", UrlHelper.jqueryMobileCSS).Include(
																									 "~/Content/jquery.mobile.*", new CssRewriteUrlTransform()));
			bundles.Add(new StyleBundle("~/Content/bootstrap", UrlHelper.bootstrapCSS).Include("~/Content/bootstrap.*",
																								new CssRewriteUrlTransform()));
			bundles.Add(
						 new StyleBundle("~/Content/bootstraptheme", UrlHelper.bootstrapThemeCSS).Include("~/Content/bootstrap-theme.*",
																										new CssRewriteUrlTransform()));
			bundles.Add(
						 new StyleBundle("~/Content/bootstrapcerulean", UrlHelper.bootstrapThemeCeruleanCSS).Include(
																													 "~/Content/bootstrap-cerulean.*", new CssRewriteUrlTransform()));

			bundles.Add(new StyleBundle("~/Content/fontawesome", UrlHelper.fontawesomeCSS).Include("~/Content/font-awesome.*",
																									new CssRewriteUrlTransform()));
			bundles.Add(new StyleBundle("~/Content/ionicons", UrlHelper.ioniconsCSS).Include("~/Content/ionicons.*",
																							new CssRewriteUrlTransform()));
			bundles.Add(new StyleBundle("~/Content/flexslider", UrlHelper.flexsliderCSS).Include("~/Content/flexslider.*",
																								new CssRewriteUrlTransform()));
			bundles.Add(new StyleBundle("~/Content/animate").Include("~/Content/animate.*", new CssRewriteUrlTransform()));
			bundles.Add(new StyleBundle("~/Content/site").Include("~/Content/site.*", new CssRewriteUrlTransform()));

			#endregion
		}
	}
}