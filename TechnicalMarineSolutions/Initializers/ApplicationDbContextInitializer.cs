namespace TechnicalMarineSolutions.Initializers
{
	#region Library Imports

	using System;
	using System.Data.Entity;
	using System.Data.Entity.Infrastructure;
	using TechnicalMarineSolutions.Extensions;
	using TechnicalMarineSolutions.Migrations;
	using TechnicalMarineSolutions.Models.Context;

	#endregion

	internal sealed class ApplicationDbContextInitializer
		: MigrateDatabaseToLatestVersion<ApplicationDbContext, MigrationConfiguration>
		//public sealed class ApplicationDbContextInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>
		//public sealed class ApplicationDbContextInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
	{
		public ApplicationDbContextInitializer()
		{
			try
			{
				using (ApplicationDbContext db = ApplicationDbContext.Create())
				{
					if (!db.Database.Exists())
					{
						// Create the database without Entity Framework migration schema
						((IObjectContextAdapter) db).ObjectContext.CreateDatabase();
						db.AddElmahFunctionality();
					}
				}
			}
			catch (Exception ex)
			{
				throw new InvalidOperationException("The database could not be initialized!", ex);
			}
		}
	}
}