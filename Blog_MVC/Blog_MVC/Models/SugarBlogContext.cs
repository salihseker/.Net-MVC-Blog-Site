using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Blog_MVC.Models.Mapping;

namespace Blog_MVC.Models
{
    public partial class SugarBlogContext : DbContext
    {
        static SugarBlogContext()
        {
            Database.SetInitializer<SugarBlogContext>(null);
        }

        public SugarBlogContext()
            : base("Name=SugarBlogContext")
        {
        }

        public DbSet<Etiket> Etikets { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<KullaniciRol> KullaniciRols { get; set; }
        public DbSet<Makale> Makales { get; set; }
        public DbSet<Resim> Resims { get; set; }
        public DbSet<Rol> Rols { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Yazar> Yazars { get; set; }
        public DbSet<Yorum> Yorums { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EtiketMap());
            modelBuilder.Configurations.Add(new KategoriMap());
            modelBuilder.Configurations.Add(new KullaniciMap());
            modelBuilder.Configurations.Add(new KullaniciRolMap());
            modelBuilder.Configurations.Add(new MakaleMap());
            modelBuilder.Configurations.Add(new ResimMap());
            modelBuilder.Configurations.Add(new RolMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new YazarMap());
            modelBuilder.Configurations.Add(new YorumMap());
        }
    }
}
