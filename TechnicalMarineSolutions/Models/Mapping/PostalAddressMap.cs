namespace TechnicalMarineSolutions.Models.Mapping
{
	#region Library Imports

	using System.Data.Entity.ModelConfiguration;
	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public class PostalAddressMap : EntityTypeConfiguration<PostalAddress>
	{
		public PostalAddressMap()
		{
			ToTable("PostalAddress", "Location");

			MapToStoredProcedures();
		}
	}
}