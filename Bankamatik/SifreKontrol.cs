using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankamatik
{
    public class SifreKontrol
    {
        public string KullaniciAdi { get; set; } = "Tuğba";
        public string Sifre { get; set; } = "0000";

        public bool girisYap(string kullaniciAdi, string sifre)
        {
            if (KullaniciAdi == kullaniciAdi && Sifre== sifre)
            {
                return true;    
            }
            else
            {
                return false;   
            }
        }

    }
}
