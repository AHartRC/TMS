#region Library Imports

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using TechnicalMarineSolutions.Extensions;
using TechnicalMarineSolutions.Managers;
using TechnicalMarineSolutions.Models.Binding;
using TechnicalMarineSolutions.Models.Context;

#endregion

namespace TechnicalMarineSolutions.Initializers
{
	public sealed class ApplicationDbContextInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>

		//public sealed class ApplicationDbContextInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
	{
		public ApplicationDbContextInitializer()
		{
			try
			{
				using (var db = ApplicationDbContext.Create())
				{
					if (!db.Database.Exists())
					{
						// Create the database without Entity Framework migration schema
						((IObjectContextAdapter) db).ObjectContext.CreateDatabase();
					}
				}
			}
			catch (Exception ex)
			{
				throw new InvalidOperationException("The database could not be initialized!", ex);
			}
		}

		protected override void Seed(ApplicationDbContext context)
		{
			context.AddElmahFunctionality();

			var store = new UserStore<ApplicationUser>(context);
			var userManager = new ApplicationUserManager(store);

			var user = new ApplicationUser
						{
							UserName = "System",
							Email = "noreply@anthonyhart.info",
							EmailConfirmed = true,
							LockoutEnabled = true,
							LockoutEndDateUtc = new DateTime(9001, 12, 31, 23, 59, 59).ToUniversalTime(),
							PhoneNumber = "9096410070",
							PhoneNumberConfirmed = true,
							TwoFactorEnabled = true
						};

			var result = userManager.Create(user, "T3chn1c@l");

			if (!result.Succeeded || result.Errors.Any())
			{
				var errors = string.Join("\r\n", result.Errors);
				throw new ApplicationException($"Unable to create System user account! Unable to proceed!\r\n{errors}");
			}

			context.Database.ExecuteSqlCommand("UPDATE dbo.Users SET Id = 'SYSTEM' WHERE UserName = 'System'");
			user = context.Users.Find("System");
			var userInfoId = context.CreateNewUserRecords(user);

			if (!(userInfoId > 0))
			{
				throw new Exception("Failed to create user information records during seeding!");
			}

			base.Seed(context);
		}
	}
}