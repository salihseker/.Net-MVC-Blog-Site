using System;
using System.Collections.Generic;

namespace Blog_MVC.Models
{
    public partial class Kullanici
    {
        public Kullanici()
        {
            this.KullaniciRols = new List<KullaniciRol>();
            this.Makales = new List<Makale>();
            this.Kullanici1 = new List<Kullanici>();
            this.Kullanicis = new List<Kullanici>();
        }

        public int KullaniciId { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }
        public string Aciklama { get; set; }
        public string MailAdres { get; set; }
        public Nullable<bool> Cinsiyet { get; set; }
        public Nullable<System.DateTime> DogumTarihi { get; set; }
        public System.DateTime KayitTarihi { get; set; }
        public Nullable<bool> Yazar { get; set; }
        public Nullable<bool> Onaylandi { get; set; }
        public Nullable<bool> Aktif { get; set; }
        public Nullable<int> ResimID { get; set; }
        public virtual Resim Resim { get; set; }
        public virtual ICollection<KullaniciRol> KullaniciRols { get; set; }
        public virtual ICollection<Makale> Makales { get; set; }
        public virtual ICollection<Kullanici> Kullanici1 { get; set; }
        public virtual ICollection<Kullanici> Kullanicis { get; set; }
    }
}
