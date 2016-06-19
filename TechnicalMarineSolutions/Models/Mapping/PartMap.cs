namespace TechnicalMarineSolutions.Models.Mapping
{
	#region Library Imports

	using System.Data.Entity.ModelConfiguration;
	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public class PartMap : EntityTypeConfiguration<Part>
	{
		public PartMap()
		{
			ToTable("Part", "Resource");

			MapToStoredProcedures();
		}
	}
}