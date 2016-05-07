#region Library Imports

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TechnicalMarineSolutions.Models.Binding;

#endregion

namespace TechnicalMarineSolutions.Models.Mapping
{
	public class ApplicationUserMap : EntityTypeConfiguration<ApplicationUser>
	{
		public ApplicationUserMap()
		{
			ToTable("AspNetUser", "User");

			HasKey(k => k.Id);

			Property(p => p.Id)

				// .HasColumnAnnotation("", )
				.HasColumnName("Id")
				.HasColumnOrder(1)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(128)
				.HasParameterName("Id")
				.IsRequired();

			Property(p => p.Email)

				// .HasColumnAnnotation("", )
				.HasColumnName("Email")
				.HasColumnOrder(2)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(128)
				.HasParameterName("Email")
				.IsOptional();

			Property(p => p.EmailConfirmed)

				// .HasColumnAnnotation("", )
				.HasColumnName("EmailConfirmed")
				.HasColumnOrder(3)
				.HasColumnType("BIT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("EmailConfirmed")
				.IsRequired();

			Property(p => p.PasswordHash)

				// .HasColumnAnnotation("", )
				.HasColumnName("PasswordHash")
				.HasColumnOrder(4)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(null)
				.HasParameterName("PasswordHash")
				.IsOptional();

			Property(p => p.SecurityStamp)

				// .HasColumnAnnotation("", )
				.HasColumnName("SecurityStamp")
				.HasColumnOrder(5)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(null)
				.HasParameterName("SecurityStamp")
				.IsOptional();

			Property(p => p.PhoneNumber)

				// .HasColumnAnnotation("", )
				.HasColumnName("PhoneNumber")
				.HasColumnOrder(6)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(null)
				.HasParameterName("PhoneNumber")
				.IsOptional();

			Property(p => p.PhoneNumberConfirmed)

				// .HasColumnAnnotation("", )
				.HasColumnName("PhoneNumberConfirmed")
				.HasColumnOrder(7)
				.HasColumnType("BIT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PhoneNumberConfirmed")
				.IsRequired();

			Property(p => p.TwoFactorEnabled)

				// .HasColumnAnnotation("", )
				.HasColumnName("TwoFactorEnabled")
				.HasColumnOrder(8)
				.HasColumnType("BIT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("TwoFactorEnabled")
				.IsRequired();

			Property(p => p.LockoutEndDateUtc)

				// .HasColumnAnnotation("", )
				.HasColumnName("LockoutEndDateUtc")
				.HasColumnOrder(9)
				.HasColumnType("DATETIME")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("LockoutEndDateUtc")
				.IsOptional();

			Property(p => p.LockoutEnabled)

				// .HasColumnAnnotation("", )
				.HasColumnName("LockoutEnabled")
				.HasColumnOrder(10)
				.HasColumnType("BIT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("LockoutEnabled")
				.IsRequired();

			Property(p => p.AccessFailedCount)

				// .HasColumnAnnotation("", )
				.HasColumnName("AccessFailedCount")
				.HasColumnOrder(11)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("AccessFailedCount")
				.IsRequired();

			Property(p => p.UserName)

				// .HasColumnAnnotation("", )
				.HasColumnName("UserName")
				.HasColumnOrder(12)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(128)
				.HasParameterName("UserName")
				.IsRequired();

			HasMany(e => e.Users)
				.WithRequired(e => e.User)
				.HasForeignKey(e => e.UserId);
		}
	}
}