using System;

namespace _12._13
{
    internal class Program
    {
        static Random r = new Random();
        static void F01(int[] szamok)
        {
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = r.Next(1, 51);
            } 
        }

        static int F02(int[] szamok)
        {
            int ossz =0;
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] % 2 == 0)
                {
                    ossz += szamok[i];
                }
            }
            return ossz;
        }

        static double F03(int[] szamok)
        {
            double atlag = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                atlag += szamok[i];
            }
            atlag /= szamok.Length;
            return atlag;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! ");
        }
    }
}