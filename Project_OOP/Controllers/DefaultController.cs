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
            mesajlar();
            return View();
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

    }
}
