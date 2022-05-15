using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSingle
{
    public class Message
    {
        //Metot

        public static void Greeting()
        {
            Console.WriteLine("Hoşgeldiniz!");

        }
        public static void ErrorGreeting(string fieldName)
        {
            Console.WriteLine($"{fieldName} boş geçilemez.");
        }
        public static void ErrorPacket()
        { 
            Console.WriteLine("Lütfen bir paket seçiniz!");
        }
    }
}
