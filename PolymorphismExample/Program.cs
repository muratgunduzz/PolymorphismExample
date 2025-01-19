/*Pratik - Polymorphism
Kare, Dikdörtgen, Dik Üçgen nesnelerinden oluşacak bir uygulamada alan hesaplaması yapmak istiyoruz.

Yukarıda bahsettiğimiz nesnelerin her birini üretebilmemiz için classlara ihtiyacımız var.

Kare

Dikdortgen

DikUcgen

Classlarımızı ortak bir çatı altında toplayarak BaseGeometrikSekil classından türetebiliriz.

BaseGeometrikSekil için Propertyler -> Genişlik ve Yükseklik

AlanHesapla() metodu tüm geometrik şekillerde bulanacağından Base Class içerisinde tanımlayabiliriz.

 

Burada dikkat etmemiz gereken durum: Kare ve Dikdortgen için Genişlik x Yükseklik şeklinde hesaplanan alanın Dik Üçgen için (Genişlik x Yükseklik ) / 2 olarak hesaplanması.

Polymorphism prensibini kullanarak ilgili uygulamayı kodlayınız. Her classtan bir örnek nesne oluşturarak Alan ölçülerini konsol ekranına yazdırınız.*/

using PolymorphismExample;
using System;

class Program
{
    public static void Main()
    {
        Kare kare = new Kare(10, 10);
        Console.WriteLine($"Kare Alanı: {kare.Alan()}");

        Dikdortgen dikdortgen = new Dikdortgen(10, 20);
        Console.WriteLine($"Dikdörtgen Alanı: {dikdortgen.Alan()}");

        Ucgen ucgen = new Ucgen(10, 20);
        Console.WriteLine($"Üçgen Alanı: {ucgen.Alan()}");
    }
}