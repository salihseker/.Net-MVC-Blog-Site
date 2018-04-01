using System;
using System.Collections.Generic;

namespace Blog_MVC.Models
{
    public partial class Makale
    {
        public Makale()
        {
            this.Resims = new List<Resim>();
            this.Yorums = new List<Yorum>();
            this.Etikets = new List<Etiket>();
        }

        public int MakaleId { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public System.DateTime EklenmeTarihi { get; set; }
        public int KategoriID { get; set; }
        public int GoruntulenmeSayisi { get; set; }
        public int Begeni { get; set; }
        public int YazarID { get; set; }
        public Nullable<int> ResimID { get; set; }
        public virtual Kategori Kategori { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        public virtual Resim Resim { get; set; }
        public virtual ICollection<Resim> Resims { get; set; }
        public virtual ICollection<Yorum> Yorums { get; set; }
        public virtual ICollection<Etiket> Etikets { get; set; }
    }
}
