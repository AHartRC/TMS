#region Library Imports

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TechnicalMarineSolutions.Models.Binding;

#endregion

namespace TechnicalMarineSolutions.Models.Mapping
{
	public class PostalAddressMap : EntityTypeConfiguration<PostalAddress>
	{
		public PostalAddressMap()
		{
			ToTable("PostalAddress", "User");

			HasKey(k => k.Id);

			Property(p => p.Id)

				// .HasColumnAnnotation("", )
				.HasColumnName("Id")
				.HasColumnOrder(1)
				.HasColumnType("BIGINT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
				.HasParameterName("Id")
				.IsRequired();

			Property(p => p.PersonalInfoId)

				// .HasColumnAnnotation("", )
				.HasColumnName("PersonalInfoId")
				.HasColumnOrder(2)
				.HasColumnType("BIGINT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PersonalInfoId")
				.IsRequired();

			Property(p => p.AddressType)

				// .HasColumnAnnotation("", )
				.HasColumnName("AddressType")
				.HasColumnOrder(3)
				.HasColumnType("BIGINT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("AddressType")
				.IsRequired();

			Property(p => p.RecordStatus)

				// .HasColumnAnnotation("", )
				.HasColumnName("RecordStatus")
				.HasColumnOrder(4)
				.HasColumnType("BIGINT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("RecordStatus")
				.IsRequired();

			Property(p => p.Recipient)

				// .HasColumnAnnotation("", )
				.HasColumnName("Recipient")
				.HasColumnOrder(5)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(128)
				.HasParameterName("Recipient")
				.IsOptional();

			Property(p => p.Attention)

				// .HasColumnAnnotation("", )
				.HasColumnName("Attention")
				.HasColumnOrder(6)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(128)
				.HasParameterName("Attention")
				.IsOptional();

			Property(p => p.Address1)

				// .HasColumnAnnotation("", )
				.HasColumnName("Address1")
				.HasColumnOrder(7)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(64)
				.HasParameterName("Address1")
				.IsRequired();

			Property(p => p.Address2)

				// .HasColumnAnnotation("", )
				.HasColumnName("Address2")
				.HasColumnOrder(8)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(64)
				.HasParameterName("Address2")
				.IsOptional();

			Property(p => p.City)

				// .HasColumnAnnotation("", )
				.HasColumnName("City")
				.HasColumnOrder(9)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(64)
				.HasParameterName("City")
				.IsRequired();

			Property(p => p.State)

				// .HasColumnAnnotation("", )
				.HasColumnName("State")
				.HasColumnOrder(10)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(2)
				.HasParameterName("State")
				.IsRequired();

			Property(p => p.PostalCode)

				// .HasColumnAnnotation("", )
				.HasColumnName("PostalCode")
				.HasColumnOrder(11)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(10)
				.HasParameterName("PostalCode")
				.IsRequired();

			HasRequired(r => r.Person)
				.WithMany(m => m.PostalAddresses)
				.HasForeignKey(fk => fk.PersonalInfoId);

			HasMany(m => m.Appointments)
				.WithRequired(r => r.PostalAddress)
				.HasForeignKey(fk => fk.PostalAddressId);
		}
	}
}