﻿namespace arrays10._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] szamLista = new int[6];

            for (int i = 0; i < szamLista.Length; i++)
            {
                Console.Write("Kérek egy számot!: ");
                szamLista[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            foreach (int i in szamLista)
            {
                Console.WriteLine(i);
            }


        }
    }
}
