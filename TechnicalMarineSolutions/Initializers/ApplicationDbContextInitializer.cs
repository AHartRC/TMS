namespace TechnicalMarineSolutions.Initializers
{
	#region Library Imports

	using System;
	using System.Data.Entity;
	using System.Data.Entity.Infrastructure;
	using TechnicalMarineSolutions.Extensions;
	using TechnicalMarineSolutions.Models.Context;

	#endregion

	//internal sealed class ApplicationDbContextInitializer : MigrateDatabaseToLatestVersion<ApplicationDbContext, MigrationConfiguration>
	internal sealed class ApplicationDbContextInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>
		//internal sealed class ApplicationDbContextInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
	{
		public ApplicationDbContextInitializer()
		{
			try
			{
				// Is this even being called anymore?
				using (ApplicationDbContext db = new ApplicationDbContext())
				{
					if (db.Database.Exists())
						return;

                    var objectContextAdapter = (IObjectContextAdapter)db;
                    var objectContext = objectContextAdapter.ObjectContext;

                    if (objectContext == null)
                        throw new ArgumentException("WTF... Why is this null?");

                    objectContext?.CreateDatabase();
                    db.AddElmahFunctionality();
				}
			}
			catch (Exception ex)
			{
				throw new InvalidOperationException("The database could not be initialized!", ex);
			}
		}
	}
}