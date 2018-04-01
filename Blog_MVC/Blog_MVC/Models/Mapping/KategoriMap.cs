using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Blog_MVC.Models.Mapping
{
    public class KategoriMap : EntityTypeConfiguration<Kategori>
    {
        public KategoriMap()
        {
            // Primary Key
            this.HasKey(t => t.KategoriId);

            // Properties
            this.Property(t => t.Adi)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Aciklama)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Kategori");
            this.Property(t => t.KategoriId).HasColumnName("KategoriId");
            this.Property(t => t.Adi).HasColumnName("Adi");
            this.Property(t => t.Aciklama).HasColumnName("Aciklama");
        }
    }
}
