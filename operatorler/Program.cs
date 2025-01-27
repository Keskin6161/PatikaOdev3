﻿using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Atama İşlemi *****");
            // Atama ve işlemli Atama
            int x = 3;
            int y = 4;
            y = y+2;

            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 2;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(y);

            Console.WriteLine("***** Mantıksal Operatörler *****");
            //Mantıksal Operatörler

            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)  
                Console.WriteLine("Perfect");

            if(isSuccess || isCompleted)  
                Console.WriteLine("Great");

            if(isSuccess && !isCompleted)  
                Console.WriteLine("Fine");


            Console.WriteLine("***** İlişkisel Operatörler *****");
            // İlişkisel Operatörler

            int a = 3;
            int b = 4;
            bool sonuc = a < b ;
            Console.WriteLine(sonuc);

            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);

            Console.WriteLine("***** Aritmetiksel Operatörler *****");

            int sayi1 = 10;
            int sayi2 =5;
            int sonuc1 = sayi1/sayi2;
            Console.WriteLine(sonuc1);
            sonuc1= sayi1*sayi2;
            Console.WriteLine(sonuc1);
            sonuc1= sayi1+sayi2;
            Console.WriteLine(sonuc1);
            sonuc1= sayi1-sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1++;
            Console.WriteLine(sonuc1);

            // % mod alma
            int sonuc2 =20%3;
            Console.WriteLine(sonuc2);

        }
    }
}
