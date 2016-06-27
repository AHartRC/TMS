namespace TechnicalMarineSolutions.Models.Binding
{
	#region Library Imports

	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Security.Claims;
	using System.Threading.Tasks;
	using Microsoft.AspNet.Identity;
	using Microsoft.AspNet.Identity.EntityFramework;
	using TechnicalMarineSolutions.Enumerators;
	using TechnicalMarineSolutions.Hashing;
	using TechnicalMarineSolutions.Interfaces.Base;
	using TechnicalMarineSolutions.Interfaces.Mapping.Many;

	#endregion

	// You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
	public class User : IdentityUser, IEntityType, IRecordStatus
	{
		public User()
		{
		}

		#region Methods

		public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
		{
			// Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
			ClaimsIdentity userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);

			// Add custom user claims here
			return userIdentity;
		}

		#endregion Methods

		#region Implementation of IEntityType

	    /// <summary>
	    ///     An identifier that distinguishes one entity type from another
	    /// </summary>
	    public long EntityTypeId => MurmurHash3.GetHashAsLong(GetType().FullName);

		#endregion

		#region Implementation of IRecordStatus

		/// <summary>
		///     The Current status of the Record
		///     <para>This is to be used for internal purposes</para>
		///     This field will be utilized for flagging records as spam/archived/deleted/featured/etc
		/// </summary>
		public RecordStatus RecordStatus
		{
			get;
			set;
		}

		#endregion
	}
}