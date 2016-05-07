#region Library Imports

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TechnicalMarineSolutions.Models.Binding;

#endregion

namespace TechnicalMarineSolutions.Models.Mapping
{
	public class PersonalInfoMap : EntityTypeConfiguration<Person>
	{
		public PersonalInfoMap()
		{
			ToTable("PersonalInfo", "User");

			HasKey(k => k.Id);

			Property(p => p.Id)

				// .HasColumnAnnotation("", )
				.HasColumnName("Id")
				.HasColumnOrder(1)
				.HasColumnType("BIGINT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
				.HasParameterName("Id")
				.IsRequired();

			Property(p => p.UserId)

				// .HasColumnAnnotation("", )
				.HasColumnName("UserId")
				.HasColumnOrder(2)
				.HasColumnType("BIGINT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("UserId")
				.IsRequired();

			Property(p => p.RecordStatus)

				// .HasColumnAnnotation("", )
				.HasColumnName("RecordStatus")
				.HasColumnOrder(3)
				.HasColumnType("BIGINT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("RecordStatus")
				.IsRequired();

			Property(p => p.FirstName)

				// .HasColumnAnnotation("", )
				.HasColumnName("FirstName")
				.HasColumnOrder(4)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(128)
				.HasParameterName("FirstName")
				.IsRequired();

			Property(p => p.MiddleName)

				// .HasColumnAnnotation("", )
				.HasColumnName("MiddleName")
				.HasColumnOrder(5)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(128)
				.HasParameterName("MiddleName")
				.IsOptional();

			Property(p => p.LastName)

				// .HasColumnAnnotation("", )
				.HasColumnName("LastName")
				.HasColumnOrder(6)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(128)
				.HasParameterName("LastName")
				.IsRequired();

			Property(p => p.Hometown)

				// .HasColumnAnnotation("", )
				.HasColumnName("Hometown")
				.HasColumnOrder(7)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(128)
				.HasParameterName("Hometown")
				.IsOptional();

			Property(p => p.CurrentTown)

				// .HasColumnAnnotation("", )
				.HasColumnName("CurrentTown")
				.HasColumnOrder(8)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(128)
				.HasParameterName("CurrentTown")
				.IsOptional();

			Property(p => p.BirthDate)

				// .HasColumnAnnotation("", )
				.HasColumnName("BirthDate")
				.HasColumnOrder(9)
				.HasColumnType("DATETIME")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("BirthDate")
				.IsOptional();

			HasRequired(r => r.User)
				.WithMany(m => m.People)
				.HasForeignKey(fk => fk.UserId);

			HasMany(m => m.Addresses)
				.WithRequired(r => r.Person)
				.HasForeignKey(fk => fk.PersonalInfoId);
		}
	}
}