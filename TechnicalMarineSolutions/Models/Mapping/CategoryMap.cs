namespace TechnicalMarineSolutions.Models.Mapping
{
	#region Library Imports

	using System.Data.Entity.ModelConfiguration;
	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public class CategoryMap : EntityTypeConfiguration<Category>
	{
		public CategoryMap()
		{
			ToTable("Category", "Schema");

			//MapToStoredProcedures();
		}
	}
}