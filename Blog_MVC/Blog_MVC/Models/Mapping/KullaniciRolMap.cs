using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Blog_MVC.Models.Mapping
{
    public class KullaniciRolMap : EntityTypeConfiguration<KullaniciRol>
    {
        public KullaniciRolMap()
        {
            // Primary Key
            this.HasKey(t => new { t.RolID, t.KullaniciID });

            // Properties
            this.Property(t => t.KullaniciRolID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.RolID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.KullaniciID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("KullaniciRol");
            this.Property(t => t.KullaniciRolID).HasColumnName("KullaniciRolID");
            this.Property(t => t.RolID).HasColumnName("RolID");
            this.Property(t => t.KullaniciID).HasColumnName("KullaniciID");

            // Relationships
            this.HasRequired(t => t.Kullanici)
                .WithMany(t => t.KullaniciRols)
                .HasForeignKey(d => d.KullaniciID);
            this.HasRequired(t => t.Rol)
                .WithMany(t => t.KullaniciRols)
                .HasForeignKey(d => d.RolID);

        }
    }
}
