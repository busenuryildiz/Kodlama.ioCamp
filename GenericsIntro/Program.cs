﻿namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");

            //List<string> liste = new List<string>();
            //Console.WriteLine(liste.Count);

            Console.WriteLine(isimler.Length);
            isimler.Add("Kerem");

            Console.WriteLine(isimler.Length);
            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }

        }
    }
}