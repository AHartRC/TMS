namespace TechnicalMarineSolutions.Models.Mapping
{
	#region Library Imports

	using System.Data.Entity.ModelConfiguration;
	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public class InformationMap : EntityTypeConfiguration<Information>
	{
		public InformationMap()
		{
			ToTable("Information", "User");

			MapToStoredProcedures();
		}
	}
}