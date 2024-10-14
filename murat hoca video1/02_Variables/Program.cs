using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenker
            /* double number;
            number = 4.85;
            Console.WriteLine(number); */

            /* Console.WriteLine("**** Fiyat Listesi **** ");
             Console.WriteLine();

             double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

             applePrice = 14.85;
             orangePrice = 20.95;
             strawberryPrice = 45;
             potatoPrice = 9.74;
             tomatoPrice = 6.88;

             Console.WriteLine("---- Elma Birim Fiyatı :" + applePrice +" TL");
             Console.WriteLine("---- Portakal Birim Fiyatı :" + orangePrice+" TL");
             Console.WriteLine("---- Çilek Birim Fiyatı :" + strawberryPrice + " TL");
             Console.WriteLine("---- Patates Birim Fiyatı :" + potatoPrice + " TL");
             Console.WriteLine("---- Domates Birim Fiyatı :" +tomatoPrice +"  TL");

             Console.WriteLine();
             Console.WriteLine();

             double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
             appleGram = 1.245;
             orangeGram = 2.650;
             strawberryGram = 0.750;
             potatoGram = 4.859;
             tomatoGram = 3.745;

             double appleTotalPrice = appleGram * applePrice;
             double orangeTotalPrice = orangeGram * orangePrice;
             double strawberryTotalPrice = strawberryGram * strawberryPrice;
             double potatoTotalPrice = potatoGram * potatoPrice;
             double tomatoTotalPrice = tomatoGram * tomatoPrice;


             Console.WriteLine("Alınan Ürün :Elma -" + "Birim Fiyat :" + applePrice + "-Gramaj:" + appleGram + "-Toplam Tutar:" + appleTotalPrice);
             Console.WriteLine("Alınan Ürün :Portakal -" + "Birim Fiyat :" + orangePrice + "-Gramaj:" + orangeGram + "-Toplam Tutar:" + orangeTotalPrice);
             Console.WriteLine("Alınan Ürün :Çilek -" + "Birim Fiyat :" + strawberryPrice + "-Gramaj:" + strawberryGram + "-Toplam Tutar:" + strawberryTotalPrice);
             Console.WriteLine("Alınan Ürün :Patates -" + "Birim Fiyat :" + potatoPrice + "-Gramaj:" + potatoGram + "-Toplam Tutar:" + potatoTotalPrice);
             Console.WriteLine("Alınan Ürün :Domates -" + "Birim Fiyat :" + tomatoPrice + "-Gramaj:" + tomatoGram + "-Toplam Tutar:" + tomatoTotalPrice);

             double shoppingTotalPrice=appleTotalPrice+orangeTotalPrice+strawberryTotalPrice+tomatoTotalPrice+potatoTotalPrice;

             Console.WriteLine();
             Console.WriteLine();

             Console.WriteLine("Alışveriş Toplam Tutar:" + shoppingTotalPrice + "TL");   */

            #endregion

            #region Char Değişkenler


            //ABCDEFGH
            //TOPLANTI SAAT 8'DE

            /* char symbol;
             symbol = 'a';
             Console.WriteLine(symbol);  */

            #endregion

            #region Klavyeden Veri Girişleri

            /* Console.WriteLine("****CSharp Hava Yolları Yolcu Bilgisi****");
             Console.WriteLine();

             string passengerName,passengerSurname ,passengerDistrict,passengerCity,passengerIdentityNumber,passengerAge;

             Console.Write("Yolcu Adını Giriniz...");
             passengerName = Console.ReadLine();

             Console.Write("Yolcu Soyadını Giriniz...");
             passengerSurname = Console.ReadLine();

             Console.Write("İlçe Bilgisini Giriniz...");
             passengerDistrict = Console.ReadLine();

             Console.Write("Şehir Bilgisinii giriniz...");
             passengerCity = Console.ReadLine();

             Console.Write("Yolcu TC Kimlik No Bilgisini Giriniz...");
             passengerIdentityNumber = Console.ReadLine();

             Console.Write("Yolcu Yaş Bilgisini Giriniz...");
             passengerAge = Console.ReadLine();

             Console.WriteLine();

             Console.WriteLine("-------------------------");
             Console.WriteLine("-Yolcu Adı: " + passengerName + " " + "-Yolcu Soyadı :"+passengerSurname+" " +passengerDistrict+" / "+passengerCity+" "+ "-TC Kimlik Numarası :" +passengerIdentityNumber+" " +"-Yaşı :" +passengerAge);
 */
            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //ABC12D

            /* int shoesPrice, computerPrice, chairPrice, tvPrice;
             shoesPrice = 1000;
             computerPrice = 2000;
             chairPrice = 5000;
             tvPrice = 12000;

             int shoeCount, computerCount, chairCount, tvCount;
             Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz:");
             shoeCount = int.Parse( Console.ReadLine());

             Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz:");
             computerCount = int.Parse( Console.ReadLine());

             Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz:");
             chairCount = int.Parse(Console.ReadLine());

             Console.Write("Lütfen Aldığınız Televizyon Sayısını Giriniz:");
              tvCount = int.Parse(Console.ReadLine());
             int totalprice =shoeCount*shoesPrice+computerCount*computerPrice+chairCount*chairPrice+tvPrice*tvCount;

             Console.WriteLine();
             Console.WriteLine("Toplam Ödemeniz Gereken Tutar"+totalprice);
 */
            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri 

            /* double exam1, exam2, exam3, result;

             Console.Write("Lütfen 1.Sınav Notunu Giriniz:");
             exam1 = double.Parse( Console.ReadLine());

             Console.Write("Lütfen 2.Sınav Notunu Giriniz:");
             exam2 = double.Parse(Console.ReadLine());

             Console.Write("Lütfen 3.Sınav Notunu Giriniz:");
             exam3 = double.Parse(Console.ReadLine());

             result = (exam1 + exam2 + exam3) / 3;
             Console.WriteLine();
             Console.WriteLine("Sınav Ortalamanız:"+result); */
            #endregion

            #region Klavyeden Karakter Girişleri

            /*  char gender;
           Console.Write("Lütfen Cinsiyet Seçiniz: K/E     ");
           gender = char.Parse(Console.ReadLine());

           Console.WriteLine("Seçtiğiniz Cinsiyet :" + gender);
           */

            #endregion



            Console.Read();
        }
    }
}
