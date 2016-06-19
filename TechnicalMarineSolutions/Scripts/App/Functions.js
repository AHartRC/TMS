// Array Remove - By John Resig (MIT Licensed)
Array.prototype.remove = function(from, to) {
	var rest = this.slice((to || from) + 1 || this.length);
	this.length = from < 0 ? this.length + from : from;
	return this.push.apply(this, rest);
};

// Error Handling
Function.prototype.trace = function() {
	var trace = [];
	var current = this;
	while (current) {
		trace.push(current.signature());
		current = current.caller;
	}
	return trace;
};

Function.prototype.signature = function() {
	var signature = {
		name: this.getName(),
		params: [],
		toString: function() {
			var params = this.params.length > 0 ?
				"'" + this.params.join("', '") + "'" : "";
			return this.name + "(" + params + ")";
		}
	};
	if (this.arguments) {
		for (var x = 0; x < this.arguments.length; x++)
			signature.params.push(this.arguments[x]);
	}
	return signature;
};

Function.prototype.getName = function() {
	if (this.name)
		return this.name;
	var definition = this.toString().split("\n")[0];
	var exp = /^function ([^\s(]+).+/;
	if (exp.test(definition))
		return definition.split("\n")[0].replace(exp, "$1") || "anonymous";
	return "anonymous";
};

window.onerror = function(msg, url, line) {
	if (arguments != null && arguments.callee != null && arguments.callee.trace)
		logError(msg, arguments.callee.trace());
};

// End Error Handling

function BingMapsCallback() {
	CleanBingMaps();
	$(".bingmap").each(function() {
		var map = $(this);
		var mapObj = map[0];
		var options = {
			credentials: "AsGp8GFgA77sXsVhB06cpGvyCZ7Hm8wyUWg65iswbK1HbR3ypRuWmzkXxinnTjXn",
			center: new window.Microsoft.Maps.Location(parseFloat(map.data("lat")), parseFloat(map.data("long"))),
			mapTypeId: window.Microsoft.Maps.MapTypeId.road,
			zoom: parseInt(map.data("zoom"))
		};
		window.Microsoft.Maps.Map(mapObj, options);
	});
}

function CleanBingMaps() {
	$(".bingmap").each(function() {
		var map = $(this);
		map.css("width", map.parent().width());
		map.css("height", ((width / 16) * 9));
		var mapObj = map[0];
		var options = {
			credentials: "AsGp8GFgA77sXsVhB06cpGvyCZ7Hm8wyUWg65iswbK1HbR3ypRuWmzkXxinnTjXn",
			center: new window.Microsoft.Maps.Location(parseFloat(map.data("lat")), parseFloat(map.data("long"))),
			mapTypeId: window.Microsoft.Maps.MapTypeId.road,
			zoom: parseInt(map.data("zoom"))
		};
		var newMap = window.Microsoft.Maps.Map(mapObj, options);
	});
}

function CleanGoogleAds() {
	//var ads = $('.adContainer');
	//ads.each(function()
	//{
	//    var ad = $(this);
	//    ad.css("width", "inherit");
	//    ad.css("margin", "auto");
	//    var insObjs = ad.find('ins');
	//    insObjs.each(function()
	//    {
	//        var insObj = $(this);
	//        insObj.css("width", ad.width());
	//        insObj.css("margin", "auto");
	//    });
	//    var iframeObjs = ad.find('iframe');
	//    iframeObjs.each(function()
	//    {
	//        var iframeObj = $(this);
	//        iframeObj.css("width", ad.width());
	//        iframeObj.css("margin", "auto");
	//    });
	//    var divObjs = ad.find('div');
	//    divObjs.each(function()
	//    {
	//        var divObj = $(this);
	//        divObj.css("width", ad.width());
	//        divObj.width("inherit");
	//        divObj.css("margin", "auto");
	//    });
	//    var imgObjs = ad.find('img');
	//    imgObjs.each(function()
	//    {
	//        var imgObj = $(this);
	//        imgObj.css("width", ad.width());
	//        imgObj.css("margin", "auto");
	//        imgObj.addClass('img-responsive');
	//    });
	//    var objObjs = ad.find('object');
	//    objObjs.each(function()
	//    {
	//        var objObj = $(this);
	//        objObj.css("width", ad.width());
	//        objObj.css("margin", "auto");
	//    });
	//});
}

function CleanGoogleMaps() {
	$("#googleMap").each(function() {
		var map = $(this);
		var width = map.parent().width();
		var height = ((width / 16) * 9);
		map.css("width", width);
		map.css("height", height);
	});
}

function FireForEffect() {
	InitializeValidation();
	InitializeSelectors();
	InitializeForms();
	InitializeTooltips();
	InitializeSpinners();
	InitializeSliders();
	InitializeSorters();
	InitializeAnimations();
	SetFormTimeout();
	ShowGoogleAds();
}

function FormTimeout(progress, check, message, submit) {
	progress.removeClass("progress-bar-info").removeClass("progress-bar-warning").removeClass("progress-bar-danger").addClass("progress-bar-success");
	progress.attr("aria-valuenow", 100);
	progress.css("width", "100%");
	check.attr("value", false);
	submit.removeClass("disabled");
	submit.removeAttr("disabled");
	message.text("The form may now be submitted.");
}

function GetBoundsZoomLevel(bounds, mapDim) {
	var worldDim = { height: 256, width: 256 };
	var zoomMax = 21;

	function latRad(lat) {
		var sin = Math.sin(lat * Math.PI / 180);
		var radX2 = Math.log((1 + sin) / (1 - sin)) / 2;
		return Math.max(Math.min(radX2, Math.PI), -Math.PI) / 2;
	}

	function zoom(mapPx, worldPx, fraction) {
		return Math.floor(Math.log(mapPx / worldPx / fraction) / Math.LN2);
	}

	var ne = bounds.getNorthEast();
	var sw = bounds.getSouthWest();
	var latFraction = (latRad(ne.lat()) - latRad(sw.lat())) / Math.PI;
	var lngDiff = ne.lng() - sw.lng();
	var lngFraction = ((lngDiff < 0) ? (lngDiff + 360) : lngDiff) / 360;
	var latZoom = zoom(mapDim.height, worldDim.height, latFraction);
	var lngZoom = zoom(mapDim.width, worldDim.width, lngFraction);
	return Math.min(latZoom, lngZoom, zoomMax);
}

function GetGoogleAd(ad, istext, isvertical) {
	if (ad == undefined) {
		console.log("The element to place the Google ad inside is NULL!");
		return;
	}
	istext = istext == undefined ? false : istext;
	isvertical = isvertical == undefined ? false : isvertical;
	var googleAdClient = "ca-pub-8124396232945027";
	var googleAdSlot = "4139271644";
	var adWidth = ad.width();
	var googleAdSize;
	if (adWidth >= 970)
		googleAdSize = ["970", "90"]; /* Large Leaderboard */
	else if (adWidth >= 728) {
		if (istext)
			googleAdSize = ["728", "15"]; /* Text - Horizontal Large */
		else
			googleAdSize = ["728", "90"]; /* Leaderboard */
	} else if (adWidth >= 468) {
		if (istext)
			googleAdSize = ["468", "15"]; /* Text - Horizontal Medium */
		else {
			if (isvertical)
				googleAdSize = ["336", "280"]; /* Large Rectangle */
			else
				googleAdSize = ["468", "90"]; /* Banner */
		}
	} else if (adWidth >= 320) {
		if (isvertical)
			googleAdSize = ["320", "180"]; /* Large Mobile Banner */
		else
			googleAdSize = ["320", "50"]; /* Mobile Banner */
	} else if (adWidth >= 300) {
		if (isvertical)
			googleAdSize = ["300", "600"]; /* Large Skyscraper */
		else
			googleAdSize = ["300", "200"]; /* Medium Rectangle */
	} else if (adWidth >= 250) {
		if (isvertical)
			googleAdSize = ["250", "250"]; /* Square */
		else
			googleAdSize = ["234", "60"]; /* Half Banner */
	} else if (adWidth >= 200) {
		if (isvertical)
			googleAdSize = ["200", "200"]; /*  */
		else
			googleAdSize = ["200", "90"]; /* RTL: Vertical X-Large */
	} else if (adWidth >= 180) {
		if (isvertical)
			googleAdSize = ["180", "150"]; /* Small Rectangle */
		else
			googleAdSize = ["180", "90"]; /* Vertical Large */
	} else if (adWidth >= 160) {
		if (isvertical)
			googleAdSize = ["160", "600"]; /* Wide Skyscraper */
		else
			googleAdSize = ["160", "90"]; /* Vertical Medium */
	} else if (adWidth >= 125)
		googleAdSize = ["125", "125"]; /* Button */
	else if (adWidth >= 120) {
		if (istext)
			googleAdSize = ["120", "90"]; /* Vertical Small */
		else {
			if (isvertical)
				googleAdSize = ["120", "600"]; /* Skyscraper */
			else
				googleAdSize = ["120", "240"]; /* Vertical Banner */
		}
	} else
		return;
	var adInsert = '<ins class="adsbygoogle" style="display:inline-block;width:'
		+ googleAdSize[0] + "px;height:"
		+ googleAdSize[1] + 'px" data-ad-client="'
		+ googleAdClient + '" data-ad-slot="'
		+ googleAdSlot + '"></ins>';
	var scriptInsert = '<script type="text/javascript">(adsbygoogle = window.adsbygoogle || []).push({});</script>';
	ad.append(adInsert);
	ad.append(scriptInsert);
}

function GoogleMapsCallback() {
	CleanGoogleMaps();
}

function InitializeAnimations() {
	wow.init();
}

function InitializeForms() {
	$("form").submit(function() {
		if ($(this).valid()) {
			$(this).find("div.form-group").each(function() {
				if ($(this).find("span.field-validation-error").length == 0)
					$(this).removeClass("has-error");
			});
		} else {
			$(this).find("div.form-group").each(function() {
				if ($(this).find("span.field-validation-error").length > 0)
					$(this).addClass("has-error");
			});
		}
		SetValidationCSS();
	});

	$("form").each(function() {
		$(this).find("div.form-group").each(function() {
			if ($(this).find("span.field-validation-error").length > 0)
				$(this).addClass("has-error");
			else
				$(this).removeClass("has-error");
		});
		SetValidationCSS();
	});
}

function InitializeSorters() {
	$("#grid").mixItUp();
}

function InitializeSelectors() {
	$(".js-activated").dropdownHover({
		instantlyCloseOthers: false,
		delay: 0
	}).dropdown();

	$("ul.dropdown-menu [data-toggle=dropdown]").on("click", function(event) {
		event.preventDefault();
		event.stopPropagation();
		$(this).parent().addClass("open");
		var menu = $(this).parent().find("ul");
		var menupos = menu.offset();
		var newpos = (menupos.left + menu.width()) + 30 > $(window).width() ? -menu.width() : $(this).parent().width();
		menu.css({ left: newpos });
	});

	//$('.chosen-select').chosen({
	//    disable_search_threshold: 25,
	//    no_results_text: "No Results Found!",
	//    width: "95%"
	//});
}

function InitializeSliders() {
	$(".flexslider .slider-main, .testimonials").flexslider({
		slideshowSpeed: 3000,
		directionNav: false,
		animation: "fade"
	});
	//$('.revSlider').revolution({
	//    delay: 10000,
	//    startwidth: 940,
	//    startheight: 400,
	//    hideThumbs: 300,
	//    navigationType: "bullet",
	//    navigationArrows: "verticalcentered",
	//    navigationStyle: "round",
	//    touchenabled: "on",
	//    navOffsetHorizontal: 0,
	//    navOffsetVertical: 10,
	//    shadow: 1,
	//    onHoverStop: "on",
	//    thumbWidth: 100,
	//    thumbHeight: 50,
	//    thumbAmount: 5,
	//    fullWidth: "on"
	//});
}

function InitializeSpinners() {
	//$('.spinner').spinner();
}

function InitializeTooltips() {
	$("[data-toggle=tooltip]").tooltip();
	$(".tip .tooltip").tooltip();

	$("[data-toggle=popover]").popover();
}

function InitializeValidation() {
	if ($.validator && $.validator != null && $.validator != undefined && $.validator.setDefaults) {
		$.validator.setDefaults({
			highlight: function(element, errorClass, validClass) {
				if (element.type === "radio")
					this.findByName(element.name).addClass(errorClass).removeClass(validClass);
				else {
					$(element).addClass(errorClass).removeClass(validClass);
					$(element).closest(".form-group").removeClass("has-success").addClass("has-error");
				}
			},
			unhighlight: function(element, errorClass, validClass) {
				if (element.type === "radio")
					this.findByName(element.name).removeClass(errorClass).addClass(validClass);
				else {
					$(element).removeClass(errorClass).addClass(validClass);
					$(element).closest(".form-group").removeClass("has-error").addClass("has-success");
				}
			}
		});
	}
	SetValidationCSS();
}

function LoadBingMapsScript() {
	var src = "https://ecn.dev.virtualearth.net/mapcontrol/mapcontrol.ashx?v=7.0&s=1&onscriptload=BingMapsCallback";
	if (!window.BingMapsScript) {
		window.BingMapsScript = document.createElement("script");
		window.BingMapsScript.setAttribute("charset", "UTF-8");
		window.BingMapsScript.setAttribute("type", "text/javascript");
		window.BingMapsScript.setAttribute("src", src);
		$("body").append(window.BingMapsScript);
	}
}

function LoadGoogleMapsScript() {
	var src = "https://maps.googleapis.com/maps/api/js?sensor=true&callback=GoogleMapsCallback";
	if (!window.GoogleMapsScript) {
		window.GoogleMapsScript = document.createElement("script");
		window.GoogleMapsScript.setAttribute("charset", "UTF-8");
		window.GoogleMapsScript.setAttribute("type", "text/javascript");
		window.GoogleMapsScript.setAttribute("src", src);
		$("body").append(window.GoogleMapsScript);
	}
}

function logError(ex, stack) {
	if (ex == null)
		return;
	if (errorsAPIUrl == null) {
		alert("errorsAPIURL must be defined.");
		return;
	}
	var url = ex.fileName != null ? ex.fileName : document.location;
	if (stack == null && ex.stack != null)
		stack = ex.stack;
	// format output
	var out = ex.message != null ? ex.name + ": " + ex.message : ex;
	out += ": at document path '" + url + "'.";
	if (stack != null)
		out += "\n  at " + stack.join("\n  at ");
	// send error message
	console.log("An Error has Occurred:");
	console.log(out);
	//$.ajax({
	//    type: 'POST',
	//    url: errorsAPIUrl,
	//    data: { value: out }
	//});
}

function OrientationChange() {
	ShowGoogleAds();
}

function pageLoad() {
	ReadyFunction();
}

function ReadyFunction() {
	FireForEffect();
}

function reCaptchaCallback() {
	console.log("reCAPTCHA Loaded");
}

function reCaptchaExpired() {
	alert("Your reCAPTCHA session has expired and needs to be renewed.");
}

function ResizeFunction() {
	CleanGoogleAds();
	CleanBingMaps();
}

function SetFormTimeout() {
	$("form").has("#BotCheck").has("#submitMessage").has(".progress-bar").each(function() {
		var form = $(this);
		var botCheck = form.find("#BotCheck"),
			submitMessage = form.find("#submitMessage"),
			progressBar = form.find(".progress-bar"),
			submit = form.find('.btn[type="submit"]');
		if ((botCheck === undefined || botCheck === null || !(botCheck.length > 0)) ||
		(submitMessage === undefined || submitMessage === null || !(submitMessage.length > 0)) ||
		(progressBar === undefined || progressBar === null || !(progressBar.length > 0)) ||
		(submit === undefined || submit === null || !(submit.length > 0))) {
			//console.log("Form is missing necessary elements. No timeout set.");
			return;
		}
		progressBar.removeClass("progress-bar-success").removeClass("progress-bar-warning").removeClass("progress-bar-danger").addClass("progress-bar-info");
		submitMessage.text("Bot Prevention Timer");
		progressBar.attr("aria-valuenow", 0);
		progressBar.css("width", "0");
		var rawMax = progressBar.attr("aria-valuemax"), /* Raw Max Value */
			rawSteps = progressBar.data("totalsteps"), /* Raw Total number of steps */
			rawMs = progressBar.data("time"); /* Raw Total Milliseconds */
		if ((rawMax === undefined || rawMax === null || !(rawMax > 0)) ||
		(rawSteps === undefined || rawSteps === null || !(rawSteps > 0)) ||
		(rawMs === undefined || rawMs === null || !(rawMs > 0))) {
			//console.log("This form does not have the timeout attributes set appropriately. No timeout set.");
			return;
		}
		var max = parseFloat(rawMax), /* Max Value */
			steps = parseInt(rawSteps), /* Total number of steps */
			ms = parseInt(rawMs); /* Total Milliseconds */
		if (max == undefined || max == NaN || !(max > 0) || steps == undefined || steps == NaN || !(steps > 0) || ms == undefined || ms == NaN || !(ms > 0)) {
			console.log("This form's set attributes are invalid! No timeout set.");
			return;
		}
		var stepval = max / steps; /* Value of each step */
		var stepint = ms / steps; /* Millisecond Interval Per Step*/
		submit.addClass("disabled");
		submit.attr("disabled", "disabled");
		var interval = setInterval(function() {
			var progress = parseFloat(progressBar.attr("aria-valuenow"));
			if (progress < max) {
				progressBar.attr("aria-valuenow", progress + stepval);
				progressBar.css("width", progress + stepval + "%");
			} else {
				clearInterval(interval);
				setTimeout(FormTimeout(progressBar, botCheck, submitMessage, submit), 600);
			}
		}, stepint);
	});

	$(".resetTimer").on("click", function() {
		var timer = $(this);
		timer.addClass("disabled").attr("disabled", "disabled");
		timer.attr("disabled", "disabled");
		SetFormTimeout();
		setTimeout(function() {
			timer.removeClass("disabled").removeAttr("disabled");
		}, 2000);
	});
}

function SetValidationCSS() {
	$("span.field-validation-error").addClass("help-block");
	$("div.validation-summary-errors").has("li:visible").addClass("alert alert-danger alert-dismissable");
	$("div.validation-summary-errors > button.close").remove();
	$("div.validation-summary-errors ul").before('<button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>');
}

function ShowGoogleAds() {
	var ads = $(".adContainer");
	$(".adContainer > ins").remove();
	setTimeout(function() {
		ads.each(function() {
			GetGoogleAd($(this), $(this).data("istext"), $(this).data("isvertical"));
		});
	}, 0);
	setTimeout(CleanGoogleAds, 300);
}