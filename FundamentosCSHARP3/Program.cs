using FundamentosCSHARP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace FundamentosCSHARP3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };


            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("iteracion: " + i + " - " + numeros[i]);
            }

            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }

       

           Console.WriteLine(".........");


             List<int> lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
              lista.Add(9);
              lista.Add(0);
          

            foreach (var numero in lista)
            {
            Console.WriteLine("elemento: "+numero);
            }

            List<Cerveza> cervezas = new List<Cerveza>() { new Cerveza(10, "Cerveza pro") };
            cervezas.Add(new Cerveza(500));
            Cerveza erdinger = new Cerveza(500,"Trigo");
            cervezas.Add(erdinger);

            foreach (var cerveza in cervezas)
            {
                Console.WriteLine("cerveza: " + cerveza.Nombre);
            }

        }
    }
}