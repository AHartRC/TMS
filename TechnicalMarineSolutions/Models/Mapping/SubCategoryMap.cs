namespace TechnicalMarineSolutions.Models.Mapping
{
	#region Library Imports

	using System.Data.Entity.ModelConfiguration;
	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public class SubCategoryMap : EntityTypeConfiguration<SubCategory>
	{
		public SubCategoryMap()
		{
			ToTable("SubCategory", "Schema");

			//MapToStoredProcedures();
		}
	}
}