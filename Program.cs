using System;

namespace _12._13
{
    internal class Program
    {
        static Random r = new Random();
        static void f01(int[] szamok)
        {
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = r.Next(1, 51);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}