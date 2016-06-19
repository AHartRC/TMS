namespace TechnicalMarineSolutions.Models.Mapping
{
	#region Library Imports

	using System.Data.Entity.ModelConfiguration;
	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public class EngineMap : EntityTypeConfiguration<Engine>
	{
		public EngineMap()
		{
			ToTable("Engine", "Asset");

			MapToStoredProcedures();
		}
	}
}