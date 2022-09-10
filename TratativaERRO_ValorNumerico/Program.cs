using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TratativaERRO_app
{
    public static class Program
    {
        static void Main(string[] args)
        {
            double Value1,
                   Value2,
                   calc;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.SetWindowSize(70, 30);
            Console.Title = "EXEMPLO TRATATIVA DE ERRO";

            Console.WriteLine("Aplicação para Tratativa de ERROS:");
            
            try
            {
                Console.WriteLine("\nEntre com o Valor 1:");
                Value1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nEntre com o Valo 2:");
                Value2 = Convert.ToDouble(Console.ReadLine());
                calc = Value1 + Value2;
                Console.WriteLine("\nResultado: {0}", calc);
            }
            catch (Exception erro)
            {
                Console.WriteLine("\nNão é possível solucionar o cálculo com os valores informados "); 
            }
            finally
            {
                Console.WriteLine("\nCÁCULO - Soma de valores");
            }
            Console.ReadKey();
        }
    }
}
