
int islem;

Console.WriteLine("Aritmetik işlemler menüsüne hoş geldiniz...");
Console.WriteLine();
Console.WriteLine("********** Menü **********\n");
Console.WriteLine("1- Aritmetik dört işlem");
Console.WriteLine("2- Üs Alma");
Console.WriteLine("3- Kök Alma");
Console.WriteLine("4- Karenin çevre ve alan hesabı");
Console.WriteLine("5- Dikdörtgende alan ve çevre hesabı");
Console.WriteLine("6- Eşkenar üçgende çevre\n");

Console.WriteLine("**************************\n");

Console.Write("İşlem yapmak istediğniz alan: ");


islem = Convert.ToInt16(Console.ReadLine());

if (islem==1)
{
    int a, b, toplam, fark, carpim, bolum;
    Console.Write("1.Sayıyı Giriniz: ");
    a = Convert.ToInt16(Console.ReadLine());
    Console.Write("2.Sayıyı Giriniz: ");
    b = Convert.ToInt16(Console.ReadLine());

    toplam = a + b;
    fark = a - b;
    carpim = a * b;
    bolum = a / b;

    Console.WriteLine("Toplam: " + toplam);
    Console.WriteLine("Fark: " + fark);
    Console.WriteLine("Çarpım: " + carpim);
    Console.WriteLine("Bölüm: " + bolum);

}

if (islem==2)
{
    double sayi, us, sonuc;
    Console.Write("Sayıyı Girin: ");
    sayi = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Üssü Girin: ");
    us = Convert.ToDouble(Console.ReadLine());
    sonuc = Math.Pow(sayi, us);
    Console.WriteLine("Sonuç: " + sonuc);


}
if (islem==3)
{
    double sayi, kok;
    Console.Write("Kökü alınacak sayıyı girin:");
    sayi = Convert.ToDouble(Console.ReadLine());
    kok = Math.Sqrt(sayi);
    Console.WriteLine("Sonuç: " + kok);
}

if(islem==4)
{
    int kenar, alan, cevre;
    Console.Write("Kenar Değeri: ");
    kenar = Convert.ToInt32(Console.ReadLine());
    alan = kenar * kenar;
    cevre = kenar * 4;
    Console.WriteLine("Alanı: " + alan);
    Console.WriteLine("Çevre: " + cevre);
}

if (islem==5)
{
    int knr1, knr2, alan, cevre;
    Console.Write("1.Kenar Değeri: ");
    knr1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("2.Kenar Değeri: ");
    knr2 = Convert.ToInt32(Console.ReadLine());
    alan = knr1 * knr2;
    cevre = knr1 * 2 + knr2 * 2;
    Console.WriteLine("Alanı: " + alan);
    Console.WriteLine("Çevre: " + cevre);
}

if(islem ==6)
{
    int kenar, cevre;
    Console.Write("Kenar Değeri: ");
    kenar = Convert.ToInt32(Console.ReadLine());
    cevre = kenar * 3;
    Console.WriteLine("Çevre: " + cevre);
}



Console.Read();
