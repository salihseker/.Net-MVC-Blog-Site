using System;
using System.Collections.Generic;

namespace Blog_MVC.Models
{
    public partial class Resim
    {
        public Resim()
        {
            this.Kullanicis = new List<Kullanici>();
            this.Makales = new List<Makale>();
        }

        public int ResimId { get; set; }
        public string KucukBoyut { get; set; }
        public string OrtaBoyut { get; set; }
        public string BuyukBoyut { get; set; }
        public string Video { get; set; }
        public Nullable<int> MakaleID { get; set; }
        public virtual ICollection<Kullanici> Kullanicis { get; set; }
        public virtual ICollection<Makale> Makales { get; set; }
        public virtual Makale Makale { get; set; }
    }
}
