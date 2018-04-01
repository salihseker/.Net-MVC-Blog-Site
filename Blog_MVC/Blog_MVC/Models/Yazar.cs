using System;
using System.Collections.Generic;

namespace Blog_MVC.Models
{
    public partial class Yazar
    {
        public int YazarId { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }
        public string MailAdres { get; set; }
        public string Aciklama { get; set; }
        public Nullable<bool> Cinsiyet { get; set; }
        public Nullable<int> ReismID { get; set; }
        public Nullable<bool> Onaylandi { get; set; }
    }
}
