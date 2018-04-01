using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Blog_MVC.Models.Mapping
{
    public class YorumMap : EntityTypeConfiguration<Yorum>
    {
        public YorumMap()
        {
            // Primary Key
            this.HasKey(t => t.YorumId);

            // Properties
            this.Property(t => t.Yorum1)
                .IsRequired()
                .HasMaxLength(1500);

            this.Property(t => t.AdSoyad)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("Yorum");
            this.Property(t => t.YorumId).HasColumnName("YorumId");
            this.Property(t => t.Yorum1).HasColumnName("Yorum");
            this.Property(t => t.MakaleID).HasColumnName("MakaleID");
            this.Property(t => t.EklenmeTarihi).HasColumnName("EklenmeTarihi");
            this.Property(t => t.AdSoyad).HasColumnName("AdSoyad");
            this.Property(t => t.Begeni).HasColumnName("Begeni");

            // Relationships
            this.HasRequired(t => t.Makale)
                .WithMany(t => t.Yorums)
                .HasForeignKey(d => d.MakaleID);

        }
    }
}
