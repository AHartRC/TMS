#region Library Imports

using System.Collections.Generic;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

#endregion

namespace TechnicalMarineSolutions.Models.View
{
	public class ManageLoginsViewModel
	{
		public IList<UserLoginInfo> CurrentLogins
		{
			get;
			set;
		}

		public IList<AuthenticationDescription> OtherLogins
		{
			get;
			set;
		}
	}
}