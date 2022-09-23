namespace Bankamatik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bankamatik bankamatik = new Bankamatik();
           
            
            bankamatik.ParaYatir(bankamatik.Miktar);


            KullaniciAdiSifreGiris();

        }

       static void KullaniciAdiSifreGiris()
        {
        int girisHakki = 3;
        SifreKontrol s = new SifreKontrol();

        while (girisHakki > 0)
            {
                Console.WriteLine("Kullanıcı Adı: ");
                string kullaniciAdi = Console.ReadLine();
                Console.WriteLine("Şifre: ");
                string sifre = Console.ReadLine();
                if (s.girisYap(kullaniciAdi, sifre))
                {
                    Console.WriteLine("Hoşgeldiniz");
                    break;

                }
                else
                {
                    girisHakki--;
                }
            }
            









    }
    }
}