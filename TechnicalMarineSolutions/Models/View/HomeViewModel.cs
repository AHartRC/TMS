namespace TechnicalMarineSolutions.Models.View
{
	#region Library Imports

	using System.Linq;
	using TechnicalMarineSolutions.Models.Context;

	#endregion

	public class HomeViewModel
	{
		private readonly ApplicationDbContext _db = new ApplicationDbContext();

		public int[] Counts => new[]
							   {
								   _db.Users.Count(),
								   _db.UserInformation.Count(),
								   _db.UserInformation.Count(),
								   _db.PostalAddresses.Count(),
								   _db.Projects.Count(),
								   _db.Steps.Count(),
								   _db.Appointments.Count(),
								   _db.Images.Count()
							   };
	}
}