#region Library Imports

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TechnicalMarineSolutions.Models.Binding;

#endregion

namespace TechnicalMarineSolutions.Models.Mapping
{
	public class ImageMap : EntityTypeConfiguration<Image>
	{
		public ImageMap()
		{
			ToTable("Image", "Asset");

			HasKey(k => k.Id);

			Property(p => p.Id)

				// .HasColumnAnnotation("", )
				.HasColumnName("Id")
				.HasColumnOrder(1)
				.HasColumnType("BIGINT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
				.HasParameterName("Id")
				.IsRequired();

			Property(p => p.RecordStatus)

				// .HasColumnAnnotation("", )
				.HasColumnName("RecordStatus")
				.HasColumnOrder(2)
				.HasColumnType("BIGINT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("RecordStatus")
				.IsRequired();

			Property(p => p.ImageStatus)

				// .HasColumnAnnotation("", )
				.HasColumnName("ImageStatus")
				.HasColumnOrder(3)
				.HasColumnType("BIGINT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("ImageStatus")
				.IsRequired();

			Property(p => p.Width)
				.HasPrecision(18, 4)

				// .HasColumnAnnotation("", )
				.HasColumnName("Width")
				.HasColumnOrder(4)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("Width")
				.IsRequired();

			Property(p => p.Height)
				.HasPrecision(18, 4)

				// .HasColumnAnnotation("", )
				.HasColumnName("Height")
				.HasColumnOrder(5)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("Height")
				.IsRequired();

			Property(p => p.Source)

				// .HasColumnAnnotation("", )
				.HasColumnName("Source")
				.HasColumnOrder(6)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(1024)
				.HasParameterName("Source")
				.IsRequired();

			Property(p => p.AltText)

				// .HasColumnAnnotation("", )
				.HasColumnName("AltText")
				.HasColumnOrder(7)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(256)
				.HasParameterName("AltText")
				.IsRequired();

			Property(p => p.Name)

				// .HasColumnAnnotation("", )
				.HasColumnName("Name")
				.HasColumnOrder(8)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(256)
				.HasParameterName("Name")
				.IsOptional();

			Property(p => p.Author)

				// .HasColumnAnnotation("", )
				.HasColumnName("Author")
				.HasColumnOrder(9)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(256)
				.HasParameterName("Author")
				.IsOptional();

			Property(p => p.Description)

				// .HasColumnAnnotation("", )
				.HasColumnName("Description")
				.HasColumnOrder(10)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(256)
				.HasParameterName("Description")
				.IsOptional();

			Property(p => p.Notes)

				// .HasColumnAnnotation("", )
				.HasColumnName("Notes")
				.HasColumnOrder(11)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(null)
				.HasParameterName("Notes")
				.IsOptional();
		}
	}
}