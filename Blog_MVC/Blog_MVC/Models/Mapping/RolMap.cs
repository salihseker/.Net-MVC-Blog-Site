using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Blog_MVC.Models.Mapping
{
    public class RolMap : EntityTypeConfiguration<Rol>
    {
        public RolMap()
        {
            // Primary Key
            this.HasKey(t => t.RolID);

            // Properties
            this.Property(t => t.RolAdi)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Rol");
            this.Property(t => t.RolID).HasColumnName("RolID");
            this.Property(t => t.RolAdi).HasColumnName("RolAdi");
        }
    }
}
