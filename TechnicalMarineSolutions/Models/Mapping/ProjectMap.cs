namespace TechnicalMarineSolutions.Models.Mapping
{
	#region Library Imports

	using System.Data.Entity.ModelConfiguration;
	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public class ProjectMap : EntityTypeConfiguration<Project>
	{
		public ProjectMap()
		{
			ToTable("Project", "Work");

			MapToStoredProcedures();
		}
	}
}