namespace Bankamatik
{
    public class Bankamatik
    {
        public int Tutar { get; set; }
        public int Miktar { get; set; }
        public void ParaYatir(int miktar)
        {
            Console.WriteLine("Yatırılacak Tutarı GİRİNİZ");
           miktar = Convert.ToInt32(Console.ReadLine());
           
            Tutar += miktar;
        }
        public void ParaCek(int miktar)
        {
            if (Tutar - miktar >= 0)
            { 
                Tutar -= miktar;
            }
            else
            {
                Console.WriteLine("Yeterli Miktarda Bakiyeniz Bulunmamaktadır.");

            }

        }
        public void SuankiBakiye()
        {
            Console.WriteLine(Tutar);

        }


    }
}
