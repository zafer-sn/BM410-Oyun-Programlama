class MyClass3
{

}
namespace Hafta2MF
{
    class Personel
    {
        public int MyProperty { get; set; }
        public string ad;
        private int yas;
        public int Yas
        {
            get
            {
                return yas * 2;
            }
            set
            {
                yas = value;
            }
        }
    }
    class MyClass1
    {
        // Nested-type
        class MyClass2
        {

        }
    }
    internal class Program
    {       
        static void Main(string[] args)
        {
            Personel p1 = new Personel();
            Personel p2 = new Personel();
            Personel p3 = new Personel();
            Personel p4 = new Personel();
            p1 = p2;
            p2 = p3;
            p3 = p4;
            p1.ad = "Ahmet";
            Console.WriteLine(p2.ad);
            Console.WriteLine(p3.ad);
            Console.WriteLine(p4.ad);
            //int deger;
            //Personel p1 = new Personel();
            //p1.Yas = 35;
            //Console.WriteLine(p1.Yas);
            //int a;
            //Console.WriteLine(p1.yas);
            //Console.WriteLine(a);
            //int[] plakalar = { 11, 34, 35 };
            //int[] sayilar = { 44, 55, 66 };
            //plakalar = sayilar;
            //sayilar[1] = 61;

            //int sayi1 = 101;
            //int sayi2 = 201;
            //sayi1 = sayi2;




            #region Diziler2
            //int[] plakalar = new int[5];
            // GameObject
            //int[] plakalar = { 11, 34, 35};
            //foreach(var plaka in plakalar)
            //{
            //    Console.WriteLine(plaka * 2);
            //}
            // object[] plakalar = { 11, 22, 34, "selam" };
            #endregion

            while (true)
            {
                Console.Write("Lütfen bir değer giriniz..:");
                string okunanDeger = Console.ReadLine();                
                if (okunanDeger == "q")
                {
                    break;
                }
                else if (okunanDeger != "q" && int.TryParse(okunanDeger, out int t))
                {
                    int okunanDegerInt = int.Parse(okunanDeger);
                    try
                    {
                        Console.WriteLine(Faktoriyel(okunanDegerInt));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        break;
                    }
                }

                }

            }
        /*
         erişim belirteci dönüş tipi isim(parametre)
        {
            işlemler
        }
         */
        public static int Faktoriyel(int sayi)
        {
            if(sayi < 0)
            {
                throw new Exception("Negatif faktoriyel olamaz!");
            }
            if(sayi == 0)
            {
                return 1;
            }
            return sayi * Faktoriyel(sayi - 1);
        }
    }
}
