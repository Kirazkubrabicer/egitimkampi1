using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egitimkampi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region yazdırmakomutları 

            //Console.WriteLine("*****Yemek kategorileri*****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana yemekler");
            //Console.WriteLine("3-Soğuk başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("*****Yemek kategorileri*****");
            #endregion


            #region stringdeğişkenler


            //string name;
            //name = "kiraz";
            //Console.Write(name);


            //string customerName;
            //string customerSurname;
            //string customerphone;
            //string customerEmail, district, city;
            //customerName = "ali";
            //customerSurname = "çınar";
            //customerphone = "996008006080";
            //customerEmail = "deneme@gmail.com";
            //district = "kadıköy";
            //city = "istanbul";

            //Console.WriteLine("****** Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("___________________");
            //Console.WriteLine("müşteri: "+ customerName + " " + customerSurname);
            //Console.WriteLine("iletişim:"+ customerphone);
            //Console.WriteLine("e mail adresi:"+ customerEmail);
            //Console.WriteLine("adres:"+ district + "/" + city);
            //Console.WriteLine("___________________");
            //Console.WriteLine();

            //customerName = "ayşegül";
            //customerSurname = "kaya";
            //customerphone = "906780890998";
            //customerEmail = "tes@gmail.com";
            //district = "sapanca";
            //city = "sakarya";
            //Console.WriteLine("___________________");
            //Console.WriteLine("müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("iletişim:" + customerphone);
            //Console.WriteLine("e mail adresi:" + customerEmail);
            //Console.WriteLine("adres:" + district + "/" + city);
            //Console.WriteLine("___________________");

                                 
            #endregion

            #region intdeğişkenler
            //int
            ///int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("*********restoran menü fiyatı******");
            Console.WriteLine();
            Console.WriteLine("----hamburger:" + hamburgerPrice + "tl");
            Console.WriteLine("----pizza:" + pizzaPrice + "tl");
            Console.WriteLine("----kola:" + cokePrice + "tl");
            Console.WriteLine("----limonata:" + lemonadePrice + "tl");
            Console.WriteLine("----kızartma:" + friesPrice + "tl");
            Console.WriteLine("----su:" + waterPrice + "tl");

            Console.WriteLine();
            Console.WriteLine("*********restoran menü fiyatı******");
            Console.WriteLine();
            int hamburgercount;
            int cokecount;
            int watercount;
            int friescount;
            int pizzacount;
            int lemonadecount;

            int totalhamburgerPrice;
            int totalcokePrice;
            int totalwaterPrice;
            int totalfriesPrice;
            int totalpizzaPrice;
            int totallemonadePrice;
            hamburgercount = 3;
            cokecount = 3;
            watercount = 3;
            friescount = 1;
            pizzacount = 0;
            lemonadecount = 0;
            totalhamburgerPrice = hamburgercount * hamburgerPrice;
            totalcokePrice = cokecount * cokePrice;
            totalwaterPrice = watercount * waterPrice;
            totalfriesPrice = friescount * friesPrice;
            totalpizzaPrice = pizzacount * pizzaPrice;
            totallemonadePrice = lemonadecount * lemonadePrice;




            Console.WriteLine("---------------");
            Console.WriteLine("hamburger tutarı: " + totalhamburgerPrice +"tl");
            Console.WriteLine("kızartma tutarı: " + totalfriesPrice +"tl");
            Console.WriteLine("pizza tutarı: " + totalpizzaPrice +"tl");
            Console.WriteLine("kola tutarı: " + totalcokePrice +"tl");
            Console.WriteLine("limonata tutarı: " + totallemonadePrice +"tl");
            Console.WriteLine("su tutarı: " + totalwaterPrice +"tl");
            Console.WriteLine();
                int totalPrice;
            totalPrice = totalhamburgerPrice + totalfriesPrice + totalpizzaPrice + totallemonadePrice + totalwaterPrice + totalcokePrice;
            Console.WriteLine("toplam öcenecek tutar : " + totalPrice);







            #endregion


            Console.Read();
        }
    }

    //yazdırma komutlar

}
    

