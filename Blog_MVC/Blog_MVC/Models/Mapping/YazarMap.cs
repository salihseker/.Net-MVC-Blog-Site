using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Blog_MVC.Models.Mapping
{
    public class YazarMap : EntityTypeConfiguration<Yazar>
    {
        public YazarMap()
        {
            // Primary Key
            this.HasKey(t => t.YazarId);

            // Properties
            this.Property(t => t.Adi)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Soyadi)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.KullaniciAdi)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Parola)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MailAdres)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Yazar");
            this.Property(t => t.YazarId).HasColumnName("YazarId");
            this.Property(t => t.Adi).HasColumnName("Adi");
            this.Property(t => t.Soyadi).HasColumnName("Soyadi");
            this.Property(t => t.KullaniciAdi).HasColumnName("KullaniciAdi");
            this.Property(t => t.Parola).HasColumnName("Parola");
            this.Property(t => t.MailAdres).HasColumnName("MailAdres");
            this.Property(t => t.Aciklama).HasColumnName("Aciklama");
            this.Property(t => t.Cinsiyet).HasColumnName("Cinsiyet");
            this.Property(t => t.ReismID).HasColumnName("ReismID");
            this.Property(t => t.Onaylandi).HasColumnName("Onaylandi");
        }
    }
}
