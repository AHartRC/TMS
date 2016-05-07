#region Library Imports

using System;
using System.Data.Entity;
using TechnicalMarineSolutions.Constants;
using TechnicalMarineSolutions.Models.Binding;

#endregion

namespace TechnicalMarineSolutions.Extensions
{
	public static class DbContextExtensions
	{
		public static void AddElmahFunctionality(this DbContext context)
		{
			// TODO: Convert this over to entity framework code-first (INCLUDING THE STORED PROCEDURES!)
			context.Database.ExecuteSqlCommand(StringConstants.Create_Elmah_Tables);
			context.Database.ExecuteSqlCommand(StringConstants.Create_Elmah_LogError_Proc);
			context.Database.ExecuteSqlCommand(StringConstants.Create_Elmah_GetErrorsXml_Proc);
			context.Database.ExecuteSqlCommand(StringConstants.Create_Elmah_GetErrorXml_Proc);
			context.SaveChanges();
		}

		public static long CreateNewUserRecords(this DbContext context, ApplicationUser user)
		{
			var userInfo = new User
							{
								UserId = user.Id,
								DisplayName = user.UserName
							};
			context.Set<User>()
					.Add(userInfo);
			context.Entry(userInfo)
					.State = EntityState.Added;

			var personalInfo = new Person
								{
									User = userInfo
								};
			context.Set<Person>()
					.Add(personalInfo);
			context.Entry(personalInfo)
					.State = EntityState.Added;
			context.SaveChanges();

			if (userInfo.Id > 0 && personalInfo.Id > 0)
			{
				return userInfo.Id;
			}
			throw new Exception("Creating new user records failed!");
		}
	}
}