using System;

namespace YoutubeDersler
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(ref number1, number2);
            //ref alternatifi out olabilir değer tipini referans olarak gönderme
            
            Console.WriteLine(result2);
            Console.WriteLine(number1);
        }


        static int Add3(ref int number1, int number2)
        {

            number1 = 30;
            return number1 + number2;
        }

        static int Add4(int sayi1 , int sayi2, int number3)
        
        {


        }
    }


}
