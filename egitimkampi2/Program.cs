using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egitimkampi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region double değişkenler
            //double number;
            //number = 4.85;

            //Console.WriteLine("*****fiyat listesi*****");
            //Console.WriteLine();
            //    double applePrice, orangePrice, strawberryPrice, patatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //patatoPrice = 9.74;
            //tomatoPrice = 6.88;
            //Console.WriteLine("---- elma birim fiyatı:" + applePrice +"tl");
            //Console.WriteLine("---- portakal birim fiyatı:" + orangePrice +"tl");
            //Console.WriteLine("---- çilek birim fiyatı:" + strawberryPrice + "tl");
            //Console.WriteLine("---- patates birim fiyatı:" + patatoPrice + "tl");
            //Console.WriteLine("---- domates birim fiyatı:" + tomatoPrice + "tl");

            //double appleGram, orangeGram, strawberryGram, patatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //patatoGram = 4.859;
            //tomatoGram = 3.745;
            //    double appletotalprice = appleGram * applePrice;
            //    double orangetotalprice = orangeGram * orangePrice;
            //    double strawberrytotalprice = strawberryGram * strawberryPrice;
            //    double patatototalprice = patatoGram * patatoPrice;
            //    double tomatototalprice = tomatoGram * tomatoPrice;
            //Console.WriteLine("Alınan ürün :Elma - " + "Birim fiyat :" + applePrice + " - Gramaj :" + appleGram + " - Toplam tutar :" + appletotalprice);
            //Console.WriteLine("Alınan ürün :Portakal - " + "Birim fiyat :" + orangePrice + " - Gramaj :" + orangeGram + " - Toplam tutar :" + orangetotalprice);
            //Console.WriteLine("Alınan ürün :Çilek - " + "Birim fiyat :" + strawberryPrice + " - Gramaj :" + strawberryGram + " - Toplam tutar :" + strawberrytotalprice);
            //Console.WriteLine("Alınan ürün :Patates - " + "Birim fiyat :" + patatoPrice + " - Gramaj :" + patatoGram + " - Toplam tutar :" + patatototalprice);
            //Console.WriteLine("Alınan ürün :Domates - " + "Birim fiyat :" + tomatoPrice + " - Gramaj :" + tomatoGram + " - Toplam tutar :" + tomatototalprice);

            //double shoppingtotalprice = appletotalprice + orangetotalprice + strawberrytotalprice + patatototalprice + tomatototalprice;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Alışveriş toplam tutar :" + shoppingtotalprice);












            #endregion
            #region Char değişkenler 
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);




            #endregion
            #region klavyeden veri girişleri string değişkenler
            //Console.WriteLine("*****CSharp Hava Yolları Yolcu Bilgisi******");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentiyNumber;
            //Console.Write("Yolcu Adı : ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı : ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi : ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Şehir Bilgisi :");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcu Yaş : ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcu TC Kimlik No : ");
            //passengerIdentiyNumber = Console.ReadLine();
            //Console.WriteLine("---------------------");
            //Console.WriteLine("Yolcu: " + passengerName + " " + passengerSurname + " " + passengerDistrict + "/" + passengerCity +" " + passengerAge + " " + passengerIdentiyNumber);






            #endregion
            #region Klavyeden tam sayı girişleri ve dönüşümler

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;
            //int shoecount, computercount, chaircount, tvcount;
            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoecount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computercount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chaircount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız tv sayısını giriniz: ");
            //tvcount = int.Parse(Console.ReadLine());
            //int totalPrice = shoecount * shoePrice + computercount * computerPrice + chaircount * chairPrice + tvPrice * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("toplam ödemeniz gereken tutar : " + totalPrice);

            #endregion
            #region klavyeden ondalıklı sayı işlemleri
            //double exam1, exam2, exam3, result;
            //Console.Write(" Lütfen 1.sınav notunu giriniz : ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write(" Lütfen 2.sınav notunu giriniz : ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write(" Lütfen 3.sınav notunu giriniz : ");
            //exam3 = double.Parse(Console.ReadLine());

            //result= (exam1 + exam2 +  exam3) /3;
            //Console.WriteLine("sınav ortalamanız:" + result);
            #endregion
            #region klavyeden karakter girişleri
            char gender;
            Console.Write("lütfen cinsiyet seçiniz:");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("seçtiğiniz cinsiyet :" + gender);
            #endregion


            Console.Read();
        }
    }
}
