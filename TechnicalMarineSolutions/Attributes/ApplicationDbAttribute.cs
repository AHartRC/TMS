using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalMarineSolutions.Attributes
{
	using System.Threading;
	using System.Web.Mvc;
	using TechnicalMarineSolutions.Initializers;

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
	public sealed class ApplicationDbAttribute : ActionFilterAttribute
	{
		private static ApplicationDbContextInitializer _initializer;
		private static object _initializerLock = new object();
		private static bool _isInitialized;

		public override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			// Ensure Membership is initialized only once per app start
			LazyInitializer.EnsureInitialized(ref _initializer, ref _isInitialized, ref _initializerLock);

			//Enable per action logging of the database here?
		}
	}
}
