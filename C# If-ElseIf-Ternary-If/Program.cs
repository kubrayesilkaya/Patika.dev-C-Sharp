﻿using System;

namespace C__If_ElseIf_Ternary_If
{

    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time >= 6 && time < 11)
                Console.WriteLine("Günaydın");
            else if (time <= 18)
                Console.WriteLine("İyi Günler!");
            else 
                Console.WriteLine("İyi Geceler!");

            string sonuc = time<= 18? "İyi Günler!" : "İyi Geceler!"; 
            // 18'den küçük eşit ise İyi Günler! döner; değilse İyi Geceler! döner.
            Console.WriteLine(sonuc);

            string sonuc2 = time<=6 && time<11 ? "Günaydın!" : time<=18 ? "İyi Günler!" : "İyi Geceler!";
            Console.WriteLine(sonuc2);
            
            
        }
    }
}