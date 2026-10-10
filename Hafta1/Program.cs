namespace Hafta1BMM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Değişkenler
            object yas = 20;
            string soyisim = null;
            int? bilecikPlaka = null; // ?
            Console.WriteLine((yas as int?) + 20);
            string isim = "Zafer";
            double kilo = 90.4;
            float boy = 1.7f;
            decimal pi = 3.14m;
            char karakter = 'Z';
            karakter.ToString();
            #endregion
            #region Değişkenler-2
            var deger1 = 15;
            // deger = "selam"; - HATA
            dynamic deger2 = 25;
            deger2 = "selam";
            object deger3 = 35;
            deger3 = "selam";
            #endregion
            #region Tür Dönüşümleri
            string dolarKuru = "47.8";
            double dolarKuruD = double.Parse(dolarKuru);
            string euroKuru = "55.7";
            float euroKuruF = Convert.ToSingle(euroKuru);
            byte istanbulPlaka = 34;
            int intIstanbulPlaka = istanbulPlaka;

            int buyukDeger = 2500;
            byte byteBuyukDeger = (byte)buyukDeger;
            Console.WriteLine(byteBuyukDeger); // Veri kaybı olur
            #endregion
            #region Akış kontrol mekanizmaları
            int ehliyetYas = 18;
            if (ehliyetYas >= 18)
            {
                Console.WriteLine("Yaş tutuyor");
            } else if (ehliyetYas > 25)
            {
                Console.WriteLine("Yaş 25 ten büyük");
            } else
            {
                Console.WriteLine("Yaş tutmuyor");
            }
            #endregion
            #region For döngüsü
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
            #endregion
            #region While DÖngüsü
            int baslangicDeger = 10;
            while(baslangicDeger < 100)
            {
                Console.WriteLine(baslangicDeger);
                baslangicDeger++;
            }
            #endregion
            #region Diziler
            int[] plakalar = new int[10]; 
            try
            {
                Console.WriteLine(plakalar[15]);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata alındı : {ex.Message}");
            }
            #endregion
            
            
        }
    }
}
