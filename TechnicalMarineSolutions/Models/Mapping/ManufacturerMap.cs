namespace TechnicalMarineSolutions.Models.Mapping
{
	#region Library Imports

	using System.Data.Entity.ModelConfiguration;
	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public class ManufacturerMap : EntityTypeConfiguration<Manufacturer>
	{
		public ManufacturerMap()
		{
			ToTable("Manufacturer", "Resource");

			MapToStoredProcedures();
		}
	}
}