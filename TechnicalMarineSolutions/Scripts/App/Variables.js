var BaseUrl = window.location.protocol + "//" + window.location.host + "/";

var APIUrl = BaseUrl + "api/";

var valuesAPIUrl = APIUrl + "values/";
var errorsAPIUrl = APIUrl + "errors/";
var locationsAPIUrl = APIUrl + "locations/";
var countriesAPIUrl = APIUrl + "countries/";
var statesAPIUrl = APIUrl + "states/";
var countiesAPIUrl = APIUrl + "counties/";
var citiesAPIUrl = APIUrl + "cities/";
var zipsAPIUrl = APIUrl + "zips/";
var placesAPIUrl = APIUrl + "places/";
var featureCodesAPIUrl = APIUrl + "featurecodes/";

var BingMapsScript;
var GoogleMapsScript;

var wow = new WOW(
	{
		boxClass: "wow", // animated element css class (default is wow)
		animateClass: "animated", // animation css class (default is animated)
		offset: 150, // distance to the element when triggering the animation (default is 0)
		mobile: true // trigger animations on mobile devices (true is default)
	}
);