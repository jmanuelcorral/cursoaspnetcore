using System;
using multi.utils;

namespace multi.console
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; 
            Console.Write("Número: "); 
            var calc = new Calculadora();
            n = int.Parse(Console.ReadLine()); 
            var results =  calc.Tabla(n);
            for(int i=0; i<11; i++) 
            { 
                Console.WriteLine($"{n} x {i} = {results[i]} "); 
            } 
             Console.ReadKey(); 
        }
    }
}
