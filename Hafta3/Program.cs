namespace Hafta3MF
{
    interface API2
    {
        public void istekAt2();
    }
    interface API
    {
        public void istekAt();
    }
    class WebAPI : API, API2
    {
        public void istekAt()
        {

        }
        public void istekAt2()
        {

        }
    }
    abstract class Birim
    {
        public void Hesapla()
        {

        }
        public abstract void VergiVer();
    }
    class Muhasebe : Birim
    {
        public override void VergiVer()
        {
            
        }
    }
    class Okul
    {
        public string Isim { get; set; }
        public int KurulusYili { get; set; }
    }
    class Universite: Okul
    {
        public string Bolumler { get; set; }
    }
    class Employee
    {
        string name;
        public int salary;
        public virtual int CalculateSalary()
        {
            return this.salary;
        }
    }
    class Manager : Employee
    {
        public int managerSalary;
        public override int CalculateSalary()
        {
            return managerSalary;
        }
    }
    internal class Anne : Object
    {

    }
    class Baba : Anne
    {

    }
    class Cocuk : Baba
    {

    }
    class Calisan
    {
        public Calisan()
        {
            Console.WriteLine("Calisan nesnesi üretildi");
        }
    }
    class Stajyer : Calisan
    {
        public Stajyer()
        {
            Console.WriteLine("Stajyer nesnesi üretildi!");
        }
    }
    // base-parent class
    class Personel
    {
        public string isim;
        protected string soyisim;
        public int yas;
        public Personel()
        {
            Console.WriteLine("Personel nesnesi üretildi!");
        }
    }
    // child-derived class
    class IdariPersonel : Personel
    {
        public void EvrakIsleri()
        {
            base.soyisim = "Test";
        }
        public IdariPersonel()
        {
            Console.WriteLine("IdariPersonel üretildi!");
        }
    }
    class AkademikPersonel : Personel
    {
        public void DersVer()
        {

        }
    }
    class Musteri
    {
        public Musteri()
        {
            Console.WriteLine("Normal YP calisti");
        }
        static Musteri()
        {
            Console.WriteLine("Static YP calisti");
        }

    }
    class Singleton
    {
        static Singleton getInstance;
        public string isim;
        public static Singleton GetInstance
        {
            get
            {
                return getInstance;
            }
        }
        Singleton()
        {
            
        }
        static Singleton()
        {
            getInstance = new Singleton();
        }
    }

    class Ogrenci
    {        
        
        string isim; // null - field // private
        string soyisim;
        int yas;

        public Ogrenci(string isim, string soyisim, int yas)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.yas = yas;
            Console.WriteLine("Ogrenci nesnesi olusturuldu!");
        }
        public Ogrenci()
        {
                
        }
        int vizeNotu;
        int odevNotu;
        int finalNotu;
        // full property
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public int Yas { get; set; } // 0 - property
        public void NotHesapla(int vizeNotu, int odevNotu, int finalNotu) // metot
        {
            this.vizeNotu = vizeNotu;
            this.odevNotu = odevNotu;
            this.finalNotu = finalNotu;
        }
        public int this[int a]
        {
            get
            {
                return a * 2;
            }
            set
            {
                a = value;
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Ogrenci o1 = new Ogrenci("Ahmet", "BULUT", 20);
            Ogrenci o2 = new Ogrenci();

            Console.WriteLine(o1.Yas);
            Console.WriteLine(o1[5]);
            Singleton s1 = Singleton.GetInstance;
            s1.isim = "Test";
            Singleton s2 = Singleton.GetInstance;
            Console.WriteLine(s2.isim);
            Singleton s3 = Singleton.GetInstance;
            Console.WriteLine(s3.isim);

            Singleton s4 = Singleton.GetInstance;
            Console.WriteLine(s4.isim);
            Console.WriteLine("-----------------------------");
            Musteri m1 = new Musteri();
            Musteri m2 = new Musteri();
            Musteri m3 = new Musteri();
            Musteri m4 = new Musteri();
            IdariPersonel ip1 = new IdariPersonel();
            Personel p1 = new Personel();
            AkademikPersonel ap1 = new AkademikPersonel();
            Console.WriteLine("*************************************");
            Stajyer stajyer1 = new Stajyer();
            Console.WriteLine("/////////////////////////////////////////");
            Employee ee1 = new Employee();
            ee1.salary = 25000;
            Manager mm1 = new Manager();
            mm1.managerSalary = 50000;
            Console.WriteLine(ee1.CalculateSalary()) ;
            Console.WriteLine(mm1.CalculateSalary()) ;
            Okul okul1 = new Okul();
            
            Universite universite1 = new Universite();
            
            Okul universite2 = new Universite();
            

            
        }
    }
}
