using System;
using System.Collections.Generic;

namespace Blog_MVC.Models
{
    public partial class KullaniciRol
    {
        public int KullaniciRolID { get; set; }
        public int RolID { get; set; }
        public int KullaniciID { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        public virtual Rol Rol { get; set; }
    }
}
