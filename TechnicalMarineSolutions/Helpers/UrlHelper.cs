namespace TechnicalMarineSolutions.Helpers
{
	public class UrlHelper
	{
#if DEBUG
		public const bool IsDebug = true;
#else
		public const bool IsDebug = false;
#endif

		#region Versions

		public const string html5ShivVersion = "3.7.0";
		public const string respondVersion = "1.4.2";
		public const string jquery2xVersion = "2.2.3";
		public const string jquery1xVersion = "1.12.3";
		public const string jqueryMigrateVersion = "1.4.0";
		public const string jqueryUIVersion = "1.11.4";
		public const string jqueryValidateVersion = "1.14.0";
		public const string jqueryValidateUnobtrusiveVersion = "5.2.3";
		public const string jqueryMobileVersion = "1.4.5";
		public const string jqueryEasingVersion = "1.3";
		public const string jqueryMixItUpVersion = "2.1.11";
		public const string jqueryColorVersion = "2.1.2";
		public const string jqueryQUnitVersion = "1.23.1";
		public const string jqueryPEPVersion = "0.4.1";
		public const string cldrVersion = "0.4.4";
		public const string globalizeVersion = "1.1.1";
		public const string signalRVersion = "2.2.0";
		public const string bootstrapVersion = "3.3.6";
		public const string bootstrapHoverDropdownVersion = "2.2.1";
		public const string fontawesomeVersion = "4.6.1";
		public const string sammyVersion = "0.7.5";
		public const string fullCalendarVersion = "2.6.1";
		public const string toastrVersion = "latest";
		public const string isotopeVersion = "2.2.2";
		public const string zocialVersion = "1.2.0";
		public const string flexsliderVersion = "2.6.0";
		public const string ioniconsVersion = "2.0.1";

		#endregion

		#region Javascript

		public const string googleAdSenseJS = "//pagead2.googlesyndication.com/pagead/js/adsbygoogle.js";

		public static string signalRJS =
			$"//ajax.aspnetcdn.com/ajax/signalr/jquery.signalr-{signalRVersion}{(IsDebug ? "." : ".min.")}js";

		public static string sammyJS = $"//raw.github.com/quirkey/sammy/master/lib/sammy{(IsDebug ? "." : ".min.")}js";

		public static string toastrJS =
			$"//cdnjs.cloudflare.com/ajax/libs/toastr.js/{toastrVersion}/js/toastr{(IsDebug ? "." : ".min.")}js";

		public static string isotopeJS =
			$"//cdnjs.cloudflare.com/ajax/libs/jquery.isotope/{isotopeVersion}/isotope.pkgd{(IsDebug ? "." : ".min.")}js";

		public static string flexsliderJS =
			$"//cdnjs.cloudflare.com/ajax/libs/flexslider/{flexsliderVersion}/jquery.flexslider{(IsDebug ? "." : ".min.")}js";

		#region Html5Shiv

		public static string html5ShivJS =
			$"//oss.maxcdn.com/libs/html5shiv/{html5ShivVersion}/html5shiv{(IsDebug ? "." : ".min.")}js";

		public static string html5ShivPrintShivJS =
			$"//oss.maxcdn.com/libs/html5shiv/{html5ShivVersion}/html5shiv-printshiv{(IsDebug ? "." : ".min.")}js";

		#endregion Html5Shiv

		#region Respond

		public static string respondJS =
			$"//ajax.aspnetcdn.com/ajax/respond/{respondVersion}/respond{(IsDebug ? "." : ".min.")}js";

		public static string respondAddListenerJS =
			$"//ajax.aspnetcdn.com/ajax/respond/{respondVersion}/respond.matchmedia.addListener{(IsDebug ? "." : ".min.")}js";

		#endregion Respond

		#region JQuery

		public static string jquery2xJS = $"//code.jquery.com/jquery-{jquery2xVersion}{(IsDebug ? "." : ".min.")}js";
		public static string jquery1xJS = $"//code.jquery.com/jquery-{jquery1xVersion}{(IsDebug ? "." : ".min.")}js";

		public static string jqueryMigrateJS =
			$"//code.jquery.com/jquery-migrate-{jqueryMigrateVersion}{(IsDebug ? "." : ".min.")}js";

		public static string jqueryUIJS = $"//code.jquery.com/ui/{jqueryUIVersion}/jquery-ui{(IsDebug ? "." : ".min.")}js";

		public static string jqueryMobileJS =
			$"//code.jquery.com/mobile/{jqueryMobileVersion}/jquery.mobile-{jqueryMobileVersion}{(IsDebug ? "." : ".min.")}js";

		public static string jqueryEasingJS =
			$"//cdnjs.cloudflare.com/ajax/libs/jquery-easing/{jqueryEasingVersion}/jquery.easing.min.js";

		public static string jqueryMixItUpJS =
			$"//cdnjs.cloudflare.com/ajax/libs/mixitup/{jqueryMixItUpVersion}/jquery.mixitup{(IsDebug ? "." : ".min.")}js";

		public static string jqueryQUnitJS =
			$"//code.jquery.com/qunit/qunit-{jqueryQUnitVersion}{(IsDebug ? "." : ".min.")}js";

		public static string jqueryPEPJS = $"//code.jquery.com/pep/{jqueryPEPVersion}/pep{(IsDebug ? "." : ".min.")}js";

		#region Validation

		public static string jqueryValidateJS =
			$"//ajax.aspnetcdn.com/ajax/jquery.validate/{jqueryValidateVersion}/jquery.validate{(IsDebug ? "." : ".min.")}js";

		public static string jqueryValidateAdditionalJS =
			$"//ajax.aspnetcdn.com/ajax/jquery.validate/{jqueryValidateVersion}/additional-methods{(IsDebug ? "." : ".min.")}js";

		public static string jqueryValidateUnobtrusiveJS =
			$"//ajax.aspnetcdn.com/ajax/mvc/{jqueryValidateUnobtrusiveVersion}/jquery.validate.unobtrusive{(IsDebug ? "." : ".min.")}js";

		public static string jqueryValidateGlobalizationJS =
			$"//raw.githubusercontent.com/johnnyreilly/jquery-validation-globalize/master/jquery.validate.globalize{(IsDebug ? "." : ".min.")}js";

		#endregion Validation

		#region Color

		public static string jqueryColorJS =
			$"//code.jquery.com/color/jquery.color-{jqueryColorVersion}{(IsDebug ? "." : ".min.")}js";

		public static string jqueryColorSVGNamesJS =
			$"//code.jquery.com/color/jquery.color.svg-names-{jqueryColorVersion}{(IsDebug ? "." : ".min.")}js";

		public static string jqueryColorPlusSVGNamesJS =
			$"//code.jquery.com/color/jquery.color.plus-names-{jqueryColorVersion}{(IsDebug ? "." : ".min.")}js";

		#endregion Color

		#endregion JQuery

		#region Bootstrap

		public static string bootstrapJS =
			$"//maxcdn.bootstrapcdn.com/bootstrap/{bootstrapVersion}/js/bootstrap{(IsDebug ? "." : ".min.")}js";

		public static string bootstrapHoverDropdownJS =
			$"//cdnjs.cloudflare.com/ajax/libs/bootstrap-hover-dropdown/{bootstrapHoverDropdownVersion}/bootstrap-hover-dropdown{(IsDebug ? "." : ".min.")}js";

		#endregion

		#region CLDR

		public static string cldrJS =
			$"//cdnjs.cloudflare.com/ajax/libs/cldrjs/{cldrVersion}/cldr{(IsDebug ? "." : ".min.")}js";

		public static string cldrEventJS =
			$"//cdnjs.cloudflare.com/ajax/libs/cldrjs/{cldrVersion}/cldr/event{(IsDebug ? "." : ".min.")}js";

		public static string cldrSupplementalJS =
			$"//cdnjs.cloudflare.com/ajax/libs/cldrjs/{cldrVersion}/cldr/supplemental{(IsDebug ? "." : ".min.")}js";

		public static string cldrUnresolvedJS =
			$"//cdnjs.cloudflare.com/ajax/libs/cldrjs/{cldrVersion}/cldr/unresolved{(IsDebug ? "." : ".min.")}js";

		#endregion CLDR

		#region Globalization Runtime

		public static string globalizeRuntimeJS =
			$"//cdnjs.cloudflare.com/ajax/libs/globalize/{globalizeVersion}/globalize-runtime{(IsDebug ? "." : ".min.")}js";

		public static string globalizeRuntimeCurrencyJS =
			$"//cdnjs.cloudflare.com/ajax/libs/globalize/{globalizeVersion}/globalize-runtime/currency{(IsDebug ? "." : ".min.")}js";

		public static string globalizeRuntimeDateJS =
			$"//cdnjs.cloudflare.com/ajax/libs/globalize/{globalizeVersion}/globalize-runtime/date{(IsDebug ? "." : ".min.")}js";

		public static string globalizeRuntimeMessageJS =
			$"//cdnjs.cloudflare.com/ajax/libs/globalize/{globalizeVersion}/globalize-runtime/message{(IsDebug ? "." : ".min.")}js";

		public static string globalizeRuntimeNumberJS =
			$"//cdnjs.cloudflare.com/ajax/libs/globalize/{globalizeVersion}/globalize-runtime/number{(IsDebug ? "." : ".min.")}js";

		public static string globalizeRuntimePluralJS =
			$"//cdnjs.cloudflare.com/ajax/libs/globalize/{globalizeVersion}/globalize-runtime/plural{(IsDebug ? "." : ".min.")}js";

		public static string globalizeRuntimeRelativeTimeJS =
			$"//cdnjs.cloudflare.com/ajax/libs/globalize/{globalizeVersion}/globalize-runtime/relative-time{(IsDebug ? "." : ".min.")}js";

		public static string globalizeRuntimeUnitJS =
			$"//cdnjs.cloudflare.com/ajax/libs/globalize/{globalizeVersion}/globalize-runtime/unit{(IsDebug ? "." : ".min.")}js";

		#endregion Globalization Runtime

		#region Globalization

		public static string globalizeJS =
			$"//cdnjs.cloudflare.com/ajax/libs/globalize/{globalizeVersion}/globalize{(IsDebug ? "." : ".min.")}js";

		public static string globalizeCurrencyJS =
			$"//cdnjs.cloudflare.com/ajax/libs/globalize/{globalizeVersion}/globalize/currency{(IsDebug ? "." : ".min.")}js";

		public static string globalizeDateJS =
			$"//cdnjs.cloudflare.com/ajax/libs/globalize/{globalizeVersion}/globalize/date{(IsDebug ? "." : ".min.")}js";

		public static string globalizeMessageJS =
			$"//cdnjs.cloudflare.com/ajax/libs/globalize/{globalizeVersion}/globalize/message{(IsDebug ? "." : ".min.")}js";

		public static string globalizeNumberJS =
			$"//cdnjs.cloudflare.com/ajax/libs/globalize/{globalizeVersion}/globalize/number{(IsDebug ? "." : ".min.")}js";

		public static string globalizePluralJS =
			$"//cdnjs.cloudflare.com/ajax/libs/globalize/{globalizeVersion}/globalize/plural{(IsDebug ? "." : ".min.")}js";

		public static string globalizeRelativeTimeJS =
			$"//cdnjs.cloudflare.com/ajax/libs/globalize/{globalizeVersion}/globalize/relative-time{(IsDebug ? "." : ".min.")}js";

		public static string globalizeUnitJS =
			$"//cdnjs.cloudflare.com/ajax/libs/globalize/{globalizeVersion}/globalize/unit{(IsDebug ? "." : ".min.")}js";

		#endregion Globalization

		#region FullCalendar

		public static string fullCalendarJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/fullcalendar{(IsDebug ? "." : ".min.")}js";

		public static string fullCalendarPrintJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/fullcalendar.print.js";

		public static string fullCalendarGCALJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/gcal.js";

		public static string fullCalendarLangAllJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang-all.js";

		public static string fullCalendarLangARMAJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/ar-ma.js";

		public static string fullCalendarLangARSAJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/ar-sa.js";

		public static string fullCalendarLangARTNJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/ar-tn.js";

		public static string fullCalendarLangARJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/ar.js";

		public static string fullCalendarLangBGJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/bg.js";

		public static string fullCalendarLangCAJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/ca.js";

		public static string fullCalendarLangCSJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/cs.js";

		public static string fullCalendarLangDAJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/da.js";

		public static string fullCalendarLangDEATJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/de-at.js";

		public static string fullCalendarLangDEJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/de.js";

		public static string fullCalendarLangELJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/el.js";

		public static string fullCalendarLangENAUJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/en-au.js";

		public static string fullCalendarLangENCAJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/en-ca.js";

		public static string fullCalendarLangENGBJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/en-gb.js";

		public static string fullCalendarLangENIEJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/en-ie.js";

		public static string fullCalendarLangENNZJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/en-nz.js";

		public static string fullCalendarLangESJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/es.js";

		public static string fullCalendarLangFAJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/fa.js";

		public static string fullCalendarLangFIJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/fi.js";

		public static string fullCalendarLangFRCAJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/fr-ca.js";

		public static string fullCalendarLangFRCHJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/fr-ch.js";

		public static string fullCalendarLangFRJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/fr.js";

		public static string fullCalendarLangHEJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/he.js";

		public static string fullCalendarLangHIJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/hi.js";

		public static string fullCalendarLangHRJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/hr.js";

		public static string fullCalendarLangHUJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/hu.js";

		public static string fullCalendarLangIDJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/id.js";

		public static string fullCalendarLangISJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/is.js";

		public static string fullCalendarLangITJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/it.js";

		public static string fullCalendarLangJAJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/ja.js";

		public static string fullCalendarLangKOJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/ko.js";

		public static string fullCalendarLangLTJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/lt.js";

		public static string fullCalendarLangLVJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/lv.js";

		public static string fullCalendarLangNBJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/nb.js";

		public static string fullCalendarLangNLJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/nl.js";

		public static string fullCalendarLangPLJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/pl.js";

		public static string fullCalendarLangPTBRJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/pt-br.js";

		public static string fullCalendarLangPTJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/pt.js";

		public static string fullCalendarLangROJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/ro.js";

		public static string fullCalendarLangRUJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/ru.js";

		public static string fullCalendarLangSKJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/sk.js";

		public static string fullCalendarLangSLJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/sl.js";

		public static string fullCalendarLangSRCYRLJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/sr-cyrl.js";

		public static string fullCalendarLangSRJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/sr.js";

		public static string fullCalendarLangSVJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/sv.js";

		public static string fullCalendarLangTHJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/th.js";

		public static string fullCalendarLangTRJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/tr.js";

		public static string fullCalendarLangUKJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/uk.js";

		public static string fullCalendarLangVIJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/vi.js";

		public static string fullCalendarLangZHCNJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/zh-cn.js";

		public static string fullCalendarLangZHTWJS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/lang/zh-tw.js";

		#endregion FullCalendar

		#endregion Javascript

		#region CSS

		public static string normalizeCSS =
			$"//normalize-css.googlecode.com/svn/trunk/normalize{(IsDebug ? "." : ".min.")}css";

		public static string fontawesomeCSS =
			$"//maxcdn.bootstrapcdn.com/font-awesome/{fontawesomeVersion}/css/font-awesome{(IsDebug ? "." : ".min.")}css";

		public static string flexsliderCSS =
			$"//cdnjs.cloudflare.com/ajax/libs/flexslider/{flexsliderVersion}/flexslider{(IsDebug ? "." : ".min.")}css";

		public static string ioniconsCSS =
			$"//code.ionicframework.com/ionicons/{ioniconsVersion}/css/ionicons{(IsDebug ? "." : ".min.")}css";

		#region JQuery UI

		public static string jqueryUIBlackTieCSS =
			$"//code.jquery.com/ui/{jqueryUIVersion}/themes/black-tie/jquery-ui{(IsDebug ? "." : ".min.")}css";

		public static string jqueryUIBlitzerCSS =
			$"//code.jquery.com/ui/{jqueryUIVersion}/themes/blitzer/jquery-ui{(IsDebug ? "." : ".min.")}css";

		public static string jqueryUICupertinoCSS =
			$"//code.jquery.com/ui/{jqueryUIVersion}/themes/cupertino/jquery-ui{(IsDebug ? "." : ".min.")}css";

		public static string jqueryUIDarkHiveCSS =
			$"//code.jquery.com/ui/{jqueryUIVersion}/themes/dark-hive/jquery-ui{(IsDebug ? "." : ".min.")}css";

		public static string jqueryUIDotLuvCSS =
			$"//code.jquery.com/ui/{jqueryUIVersion}/themes/dot-luv/jquery-ui{(IsDebug ? "." : ".min.")}css";

		public static string jqueryUIEggplantCSS =
			$"//code.jquery.com/ui/{jqueryUIVersion}/themes/eggplant/jquery-ui{(IsDebug ? "." : ".min.")}css";

		public static string jqueryUIExciteBikeCSS =
			$"//code.jquery.com/ui/{jqueryUIVersion}/themes/excite-bike/jquery-ui{(IsDebug ? "." : ".min.")}css";

		public static string jqueryUIFlickCSS =
			$"//code.jquery.com/ui/{jqueryUIVersion}/themes/flick/jquery-ui{(IsDebug ? "." : ".min.")}css";

		public static string jqueryUIHotSneaksCSS =
			$"//code.jquery.com/ui/{jqueryUIVersion}/themes/hot-sneaks/jquery-ui{(IsDebug ? "." : ".min.")}css";

		public static string jqueryUIHumanityCSS =
			$"//code.jquery.com/ui/{jqueryUIVersion}/themes/humanity/jquery-ui{(IsDebug ? "." : ".min.")}css";

		public static string jqueryUILeFrogCSS =
			$"//code.jquery.com/ui/{jqueryUIVersion}/themes/le-frog/jquery-ui{(IsDebug ? "." : ".min.")}css";

		public static string jqueryUIMintChocolateCSS =
			$"//code.jquery.com/ui/{jqueryUIVersion}/themes/mint-choc/jquery-ui{(IsDebug ? "." : ".min.")}css";

		public static string jqueryUIOvercastCSS =
			$"//code.jquery.com/ui/{jqueryUIVersion}/themes/overcast/jquery-ui{(IsDebug ? "." : ".min.")}css";

		public static string jqueryUIPepperGrinderCSS =
			$"//code.jquery.com/ui/{jqueryUIVersion}/themes/pepper-grinder/jquery-ui{(IsDebug ? "." : ".min.")}css";

		public static string jqueryUIRedmondCSS =
			$"//code.jquery.com/ui/{jqueryUIVersion}/themes/redmond/jquery-ui{(IsDebug ? "." : ".min.")}css";

		public static string jqueryUISmoothnessCSS =
			$"//code.jquery.com/ui/{jqueryUIVersion}/themes/smoothness/jquery-ui{(IsDebug ? "." : ".min.")}css";

		public static string jqueryUISouthStreetCSS =
			$"//code.jquery.com/ui/{jqueryUIVersion}/themes/south-street/jquery-ui{(IsDebug ? "." : ".min.")}css";

		public static string jqueryUIStartCSS =
			$"//code.jquery.com/ui/{jqueryUIVersion}/themes/start/jquery-ui{(IsDebug ? "." : ".min.")}css";

		public static string jqueryUISunnyCSS =
			$"//code.jquery.com/ui/{jqueryUIVersion}/themes/sunny/jquery-ui{(IsDebug ? "." : ".min.")}css";

		public static string jqueryUISwankyPurseCSS =
			$"//code.jquery.com/ui/{jqueryUIVersion}/themes/swanky-purse/jquery-ui{(IsDebug ? "." : ".min.")}css";

		public static string jqueryUITrontasticCSS =
			$"//code.jquery.com/ui/{jqueryUIVersion}/themes/trontastic/jquery-ui{(IsDebug ? "." : ".min.")}css";

		public static string jqueryUIDarknessCSS =
			$"//code.jquery.com/ui/{jqueryUIVersion}/themes/ui-darkness/jquery-ui{(IsDebug ? "." : ".min.")}css";

		public static string jqueryUILightnessCSS =
			$"//code.jquery.com/ui/{jqueryUIVersion}/themes/ui-lightness/jquery-ui{(IsDebug ? "." : ".min.")}css";

		public static string jqueryUIVaderCSS =
			$"//code.jquery.com/ui/{jqueryUIVersion}/themes/vader/jquery-ui{(IsDebug ? "." : ".min.")}css";

		#endregion

		#region JQuery Mobile

		public static string jqueryMobileStructureCSS =
			$"//code.jquery.com/mobile/{jqueryMobileVersion}/jquery.mobile.structure-{jqueryMobileVersion}{(IsDebug ? "." : ".min.")}css";

		public static string jqueryMobileCSS =
			$"//code.jquery.com/mobile/{jqueryMobileVersion}/jquery.mobile-{jqueryMobileVersion}{(IsDebug ? "." : ".min.")}css";

		#endregion JQuery Mobile

		#region Bootstrap

		public static string bootstrapCSS =
			$"//maxcdn.bootstrapcdn.com/bootstrap/{bootstrapVersion}/css/bootstrap{(IsDebug ? "." : ".min.")}css";

		public static string bootstrapThemeCSS =
			$"//maxcdn.bootstrapcdn.com/bootstrap/{bootstrapVersion}/css/bootstrap-theme{(IsDebug ? "." : ".min.")}css";

		public static string bootstrapThemeCeruleanCSS =
			$"//maxcdn.bootstrapcdn.com/bootswatch/{bootstrapVersion}/cerulean/bootstrap{(IsDebug ? "." : ".min.")}css";

		public static string bootstrapThemeCosmoCSS =
			$"//maxcdn.bootstrapcdn.com/bootswatch/{bootstrapVersion}/cosmo/bootstrap{(IsDebug ? "." : ".min.")}css";

		public static string bootstrapThemeCyborgCSS =
			$"//maxcdn.bootstrapcdn.com/bootswatch/{bootstrapVersion}/cyborg/bootstrap{(IsDebug ? "." : ".min.")}css";

		public static string bootstrapThemeDarklyCSS =
			$"//maxcdn.bootstrapcdn.com/bootswatch/{bootstrapVersion}/darkly/bootstrap{(IsDebug ? "." : ".min.")}css";

		public static string bootstrapThemeFlatlyCSS =
			$"//maxcdn.bootstrapcdn.com/bootswatch/{bootstrapVersion}/flatly/bootstrap{(IsDebug ? "." : ".min.")}css";

		public static string bootstrapThemeJournalCSS =
			$"//maxcdn.bootstrapcdn.com/bootswatch/{bootstrapVersion}/journal/bootstrap{(IsDebug ? "." : ".min.")}css";

		public static string bootstrapThemeLumenCSS =
			$"//maxcdn.bootstrapcdn.com/bootswatch/{bootstrapVersion}/lumen/bootstrap{(IsDebug ? "." : ".min.")}css";

		public static string bootstrapThemePaperCSS =
			$"//maxcdn.bootstrapcdn.com/bootswatch/{bootstrapVersion}/paper/bootstrap{(IsDebug ? "." : ".min.")}css";

		public static string bootstrapThemeReadableCSS =
			$"//maxcdn.bootstrapcdn.com/bootswatch/{bootstrapVersion}/readable/bootstrap{(IsDebug ? "." : ".min.")}css";

		public static string bootstrapThemeSandstoneCSS =
			$"//maxcdn.bootstrapcdn.com/bootswatch/{bootstrapVersion}/sandstone/bootstrap{(IsDebug ? "." : ".min.")}css";

		public static string bootstrapThemeSimplexCSS =
			$"//maxcdn.bootstrapcdn.com/bootswatch/{bootstrapVersion}/simplex/bootstrap{(IsDebug ? "." : ".min.")}css";

		public static string bootstrapThemeSlateCSS =
			$"//maxcdn.bootstrapcdn.com/bootswatch/{bootstrapVersion}/slate/bootstrap{(IsDebug ? "." : ".min.")}css";

		public static string bootstrapThemeSpacelabCSS =
			$"//maxcdn.bootstrapcdn.com/bootswatch/{bootstrapVersion}/spacelab/bootstrap{(IsDebug ? "." : ".min.")}css";

		public static string bootstrapThemeSuperheroCSS =
			$"//maxcdn.bootstrapcdn.com/bootswatch/{bootstrapVersion}/superhero/bootstrap{(IsDebug ? "." : ".min.")}css";

		public static string bootstrapThemeUnitedCSS =
			$"//maxcdn.bootstrapcdn.com/bootswatch/{bootstrapVersion}/united/bootstrap{(IsDebug ? "." : ".min.")}css";

		public static string bootstrapThemeYetiCSS =
			$"//maxcdn.bootstrapcdn.com/bootswatch/{bootstrapVersion}/yeti/bootstrap{(IsDebug ? "." : ".min.")}css";

		#endregion Boostrap

		#region FullCalendar

		public static string fullCalendarCSS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/fullcalendar{(IsDebug ? "." : ".min.")}css";

		public static string fullCalendarPrintCSS =
			$"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/{fullCalendarVersion}/fullcalendar.print.css";

		#endregion FullCalendar

		#region Zocial CSS Social Icons

		public static string zocialCSS =
			$"//cdnjs.cloudflare.com/ajax/libs/css-social-buttons/{zocialVersion}/css/zocial{(IsDebug ? "." : ".min.")}css";

		public static string zocialEOT = $"//cdnjs.cloudflare.com/ajax/libs/css-social-buttons/{zocialVersion}/css/zocial.eot";
		public static string zocialSVG = $"//cdnjs.cloudflare.com/ajax/libs/css-social-buttons/{zocialVersion}/css/zocial.svg";
		public static string zocialTTF = $"//cdnjs.cloudflare.com/ajax/libs/css-social-buttons/{zocialVersion}/css/zocial.ttf";

		public static string zocialWOFF =
			$"//cdnjs.cloudflare.com/ajax/libs/css-social-buttons/{zocialVersion}/css/zocial.woff";

		#endregion Zocial CSS Social Icons

		#endregion CSS
	}
}