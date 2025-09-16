using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace imposto__de_renda
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, d, resultado, li = 0;
            Console.WriteLine("coloque seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("coloque se cpf");
            string cpf = Console.ReadLine();
            Console.WriteLine("coloque seu rendimento bruto");
            r = double.Parse(Console.ReadLine());
            Console.WriteLine("coloque o total de despesas dedutiveis");
            d = double.Parse(Console.ReadLine());
            resultado = r - d;
            Console.WriteLine(resultado);

            if (resultado <= 28559.70)
            {
                Console.WriteLine("isento");
            }
            
            else if(resultado >= 28559.71 && resultado <= 34000.00)
            {
                Console.WriteLine("sua taxa de imposto é 7,5%");
                li = (resultado * 0.075);
            }
            
                
                else if(resultado >= 34000.01 && resultado <= 45000.00)
            
            {
                Console.WriteLine("sua taxa de imposto é de 15%");
                li = (resultado * 0.015);
            }
            
                
                else if(resultado >= 45000.01 && resultado <= 55000.00)
            
            {
                Console.WriteLine("sua taxa de imposto é de 22%");
                li = (resultado * 0.025);
            }
            
         
                else if(resultado > 55000.00) 
            
            {
                Console.WriteLine("sua taxa de imposto é de 27,55%");
                li = (resultado * 2.755);
            }
            {
                Console.ReadKey();
            }
        }
    }
}
      