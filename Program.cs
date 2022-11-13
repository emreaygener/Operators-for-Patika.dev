using System;

namespace operatörler
{
    class Program
    {
        static void Main(string[] args)
        {

Console.WriteLine("```Atama ve işlemli atama```");

            // Atama ve işlemli atama
            int x = 3;
            int y = 3;
            y = y + 2;
            Console.WriteLine(y);
            y += 2;    //bir üstteki ile aynı
            Console.WriteLine(y);

            y /= 1;  //y=y/1 e eşit olur
            Console.WriteLine(y);
            x *= 2;  //x=x*2 olur
            Console.WriteLine(x);

Console.WriteLine("```Mantiksal operatörler```");

            //Mantıksal operatörler
            // ||(veya),&&(ve),!(değil)
            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
                Console.WriteLine("Perfect!");
            
            if (isSuccess || isCompleted)
                Console.WriteLine("Great!");
            
            if (isSuccess && !isCompleted)
                Console.WriteLine("you are doing great!");

Console.WriteLine("```İlişkisel operatörler```");

            // İlişkisel operatörler
            //<, >, <=, >=, ==, !=

            int a=3;
            int b=4;
            bool sonuc = a<b;
            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a>=b;
            Console.WriteLine(sonuc);
            sonuc = a<=b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);
            sonuc = a!=b;
            Console.WriteLine(sonuc);

Console.WriteLine("```Aritmetik operatörler```");

            // Aritmetik operatörler 
            // +, -, *, /, ++ (+1)
            int sayi1=10;
            int sayi2=5;
            int sonuc1=sayi1+sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1-sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1*sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1/sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1++;
            Console.WriteLine(sonuc1); //derste burası sayi1 kaldığı için olduğunu düşündünüz sanırım ancak değişen bir durum olmuyor böyle iken

            // %: mod almak için kullanılır, böldükten sonra kalanı getirir
            int sonuc2 = 20%3;
            Console.WriteLine(sonuc2);

        }
    }
}
