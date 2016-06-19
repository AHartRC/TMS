namespace TechnicalMarineSolutions.Models.Mapping
{
	#region Library Imports

	using System.Data.Entity.ModelConfiguration;
	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public class TertiaryCategoryMap : EntityTypeConfiguration<TertiaryCategory>
	{
		public TertiaryCategoryMap()
		{
			ToTable("TertiaryCategory", "Schema");

			MapToStoredProcedures();
		}
	}
}