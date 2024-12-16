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

        static int[] F04(int[] szamok)
        {
            int[] paratlanok = new int[10];
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] % 2 == 0)
                {
                    paratlanok[i] = szamok[i] + 1;
                }
                else
                {
                    paratlanok[i] = szamok[i];
                }
            }
            return paratlanok;
        }

        static void F05(int[] szamok)
        {
            System.Console.WriteLine("Ennyi db pozi szám van a tombben: " + F02(szamok));
            System.Console.WriteLine("A tömb elemeinek átlaga: " + F03(szamok));
            System.Console.WriteLine("A tömbbol alkotott paratlan szamok: ");
            foreach (var item in F04(szamok))
            {
                System.Console.Write(item + ", ");
            }
            System.Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! ");
        }
    }
}