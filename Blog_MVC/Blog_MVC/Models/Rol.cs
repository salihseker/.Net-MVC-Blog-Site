using System;
using System.Collections.Generic;

namespace Blog_MVC.Models
{
    public partial class Rol
    {
        public Rol()
        {
            this.KullaniciRols = new List<KullaniciRol>();
        }

        public int RolID { get; set; }
        public string RolAdi { get; set; }
        public virtual ICollection<KullaniciRol> KullaniciRols { get; set; }
    }
}
