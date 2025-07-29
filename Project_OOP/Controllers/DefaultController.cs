using Microsoft.AspNetCore.Mvc;
using Project_OOP.Ornekler;

namespace Project_OOP.Controllers
{
    public class DefaultController : Controller
    {
        //void İşlemler()
        //{
        //    Class1 c = new Class1();
        //    c.Topla();
        //    c.Çarp();
        //}

        void mesajlar()
        {
            ViewBag.m1 = "Merhaba Dünya";
            ViewBag.m2 = "Hoşgeldiniz";
            ViewBag.m3 = "İyi Günler";
        }

        int topla()
        {
            int sayi1 = 10;
            int sayi2 = 11;
            int sonuc = sayi1 + sayi2;
            return sonuc;
        }

        int çevre()
        {
            int kenar1 = 10;
            int kenar2 = 20;
            int sonuç = 2 * (kenar1 + kenar2);
            return sonuç;
        }

        int faktöriyel(int sayi)
        {
            if (sayi == 0 || sayi == 1)
                return 1;
            else
                return sayi * faktöriyel(sayi - 1);
        }

        string cümle()
        {
            string c1 = "Merhaba";
            string c2 = "Dünya";
            string c3 = c1 + " " + c2;
            return c3;
        }

        public IActionResult Index()
        {
            Kullanıcı("Mert Ali");
            MesajListesi("Mert");
            mesajlar();
            ViewBag.m9 = Topla(5, 10);
            return View();
        }

        void Kullanıcı(string kullanıcıadı)
        {
            ViewBag.k = kullanıcıadı;
        }

        public IActionResult Ürünler()
        {
            mesajlar();
            ViewBag.m4 = topla();
            ViewBag.m5 = çevre();
            ViewBag.m6 = faktöriyel(5);
            return View();
        }

        public IActionResult Müşteriler()
        {
            ViewBag.m7 = cümle();
            return View();
        }

        void MesajListesi(string p)
        {
            ViewBag.m8 = p;
        }

        int Topla(int a, int b)
        {
            int s = a + b;
            return s;
        }

        int fak(int p)
        {
            int f = 1;
            for (int i = 1; i <= p; i++)
            {
                f *= i;
            }
            return f;
        }

        public IActionResult Deneme()
        {
            Şehirler şehirler = new Şehirler();

            şehirler.ŞehirAdı = "İstanbul";
            şehirler.ŞehirId = 1;
            şehirler.ŞehirNüfus = 15000000;
            şehirler.Ülke = "Türkiye";
            şehirler.Renk1 = "Kırmızı";
            şehirler.Renk2 = "Beyaz";
            şehirler.Bayrakemoji = "🇹🇷";
            ViewBag.a1 = şehirler.ŞehirAdı;
            ViewBag.a2 = şehirler.ŞehirId;
            ViewBag.a3 = şehirler.ŞehirNüfus;
            ViewBag.a4 = şehirler.Ülke;
            ViewBag.a5 = şehirler.Renk1;
            ViewBag.a6 = şehirler.Renk2;
            ViewBag.a7 = şehirler.Bayrakemoji;


            şehirler.ŞehirAdı = "Ankara";
            şehirler.ŞehirId = 2;
            şehirler.ŞehirNüfus = 5000000;
            şehirler.Ülke = "Türkiye";
            şehirler.Renk1 = "Kırmızı";
            şehirler.Renk2 = "Beyaz";
            şehirler.Bayrakemoji = "🇹🇷";
            ViewBag.b1 = şehirler.ŞehirAdı;
            ViewBag.b2 = şehirler.ŞehirId;
            ViewBag.b3 = şehirler.ŞehirNüfus;
            ViewBag.b4 = şehirler.Ülke;
            ViewBag.b5 = şehirler.Renk1;
            ViewBag.b6 = şehirler.Renk2;
            ViewBag.b7 = şehirler.Bayrakemoji;


            şehirler.ŞehirAdı = "İzmir";
            şehirler.ŞehirId = 3;
            şehirler.ŞehirNüfus = 4000000;
            şehirler.Ülke = "Türkiye";
            şehirler.Renk1 = "Kırmızı";
            şehirler.Renk2 = "Beyaz";
            şehirler.Bayrakemoji = "🇹🇷";
            ViewBag.c1 = şehirler.ŞehirAdı;
            ViewBag.c2 = şehirler.ŞehirId;
            ViewBag.c3 = şehirler.ŞehirNüfus;
            ViewBag.c4 = şehirler.Ülke;
            ViewBag.c5 = şehirler.Renk1;
            ViewBag.c6 = şehirler.Renk2;
            ViewBag.c7 = şehirler.Bayrakemoji;

            return View();
        }
    }
}
