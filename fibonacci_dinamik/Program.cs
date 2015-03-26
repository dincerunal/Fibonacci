using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dıncer
{
class Program
{
    static int sayac_recursive = 0;         //recursive icin sayac tanımlanır
    static int sayac_dinamik = 0;           //  dinamik  icin sayac tanımlanır
    static void Main(string[] args)
    {
        int fibonacci_sirasi;
        int k;
        Console.WriteLine("Bulmak istediğiniz fibonacci sayısını giriniz:");        //kullanıcıdan sayi istenir
        fibonacci_sirasi = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("dinamik icin 0 recursive icin 1 giriniz");           //sonucu dinamik yada recursive görmek için kullanıcıya secim yaptırılır
        k = Convert.ToInt32(Console.ReadLine());
        switch(k)
        {
            case 1:
                Console.WriteLine("——-recursive———-");
                Console.WriteLine("fibonacci({0})={1}", fibonacci_sirasi, fibonacci_recursive(fibonacci_sirasi - 1));       //bu sayının recursive sonucu
                Console.WriteLine("Recursive program sayaci={0}", sayac_recursive);              //recursive sonunda islem sayısı
            break;
            case 0:

                Console.WriteLine("——-dinamik programlama———-");
                Console.WriteLine("fibonacci({0})={1}", fibonacci_sirasi, fibonacci_dinamik_programlama(fibonacci_sirasi - 1));     //bu sayının dinamik sonucu
                Console.WriteLine("Dinamik programlama sayaci={0}", sayac_dinamik);                         //dinamik programlama  sonunda islem sayısı
                break;
        }
        Console.ReadLine();

    }
    public static int fibonacci_dinamik_programlama(int fibonacci_sirasi)       
    {
        sayac_dinamik++;        //her işlem için sayac artırılır
        int[] fibo_sayilar = new int[100];  //fibonacci sayıları dizide tutulur
        {
            for (int i = 0; i <= fibonacci_sirasi; i++)     //döngü yardımıyla sayı hesaplanır
            {
                if (i == 0 || i == 1)
                {
                    fibo_sayilar[0] = 1;        // girilen sayı 1 veya 0 mı diye kontrol edilir 
                    fibo_sayilar[1] = 1;        // dizi ilk 2 elemana 1 atanır
                }
                else
                {
                    fibo_sayilar[i] = fibo_sayilar[i - 1] + fibo_sayilar[i - 2];    //girilen sayı 1 veya 0 degilse kendisinden  önceki sayı toplanır
                }

            }
            return fibo_sayilar[fibonacci_sirasi];              // sonuc return edilir
        }
    }
    public static int fibonacci_recursive(int fibonacci_sirasi)
    {
        if (fibonacci_sirasi <= 1)              //girilen sayı 1 den kücük yada esit olma durumu kontrol edilir
        {
            sayac_recursive++;                  //sayac artırılır
            return 1;                       //sayı sayı 1 den kücük yada esitse 1 degeri return edilir
        }
        else
        {
            sayac_recursive++;              //sayac artırılır
            return (fibonacci_recursive(fibonacci_sirasi - 1) + fibonacci_recursive(fibonacci_sirasi - 2));     //girilen sayı 1 den büyükse kendinden 2 önceki sayı toplanır
        }
    }
}
}