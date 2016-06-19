namespace TechnicalMarineSolutions.Migrations
{
	#region Library Imports

	using System.Data.Entity.Migrations;
	using TechnicalMarineSolutions.Models.Context;

	#endregion

	internal sealed class MigrationConfiguration : DbMigrationsConfiguration<ApplicationDbContext>
	{
		public MigrationConfiguration()
		{
			AutomaticMigrationsEnabled = true;
			AutomaticMigrationDataLossAllowed = false;
			ContextKey = "TechnicalMarineSolutions.Models.Context.ApplicationDbContext";
		}

		protected override void Seed(ApplicationDbContext context)
		{
			//  This method will be called after migrating to the latest version.

			//  You can use the DbSet<T>.AddOrUpdate() helper extension method 
			//  to avoid creating duplicate seed data. E.g.
			//
			//    context.People.AddOrUpdate(
			//      p => p.FullName,
			//      new Person { FullName = "Andrew Peters" },
			//      new Person { FullName = "Brice Lambson" },
			//      new Person { FullName = "Rowan Miller" }
			//    );
			//
		}
	}
}