namespace TechnicalMarineSolutions.Models.Mapping
{
	#region Library Imports

	using System.Data.Entity.ModelConfiguration;
	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public class ImageMap : EntityTypeConfiguration<Image>
	{
		public ImageMap()
		{
			ToTable("Image", "Resource");

			//MapToStoredProcedures();
		}
	}
}