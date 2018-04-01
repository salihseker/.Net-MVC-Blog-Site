using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Blog_MVC.Models.Mapping
{
    public class KullaniciMap : EntityTypeConfiguration<Kullanici>
    {
        public KullaniciMap()
        {
            // Primary Key
            this.HasKey(t => t.KullaniciId);

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
                .HasMaxLength(200);

            this.Property(t => t.MailAdres)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Kullanici");
            this.Property(t => t.KullaniciId).HasColumnName("KullaniciId");
            this.Property(t => t.Adi).HasColumnName("Adi");
            this.Property(t => t.Soyadi).HasColumnName("Soyadi");
            this.Property(t => t.KullaniciAdi).HasColumnName("KullaniciAdi");
            this.Property(t => t.Parola).HasColumnName("Parola");
            this.Property(t => t.Aciklama).HasColumnName("Aciklama");
            this.Property(t => t.MailAdres).HasColumnName("MailAdres");
            this.Property(t => t.Cinsiyet).HasColumnName("Cinsiyet");
            this.Property(t => t.DogumTarihi).HasColumnName("DogumTarihi");
            this.Property(t => t.KayitTarihi).HasColumnName("KayitTarihi");
            this.Property(t => t.Yazar).HasColumnName("Yazar");
            this.Property(t => t.Onaylandi).HasColumnName("Onaylandi");
            this.Property(t => t.Aktif).HasColumnName("Aktif");
            this.Property(t => t.ResimID).HasColumnName("ResimID");

            // Relationships
            this.HasMany(t => t.Kullanici1)
                .WithMany(t => t.Kullanicis)
                .Map(m =>
                    {
                        m.ToTable("YazarTakip");
                        m.MapLeftKey("YazarID");
                        m.MapRightKey("KullaniciID");
                    });

            this.HasOptional(t => t.Resim)
                .WithMany(t => t.Kullanicis)
                .HasForeignKey(d => d.ResimID);

        }
    }
}
