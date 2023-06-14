using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08repeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();

            nomes.Add("Stella");
            nomes.Add("William");
            nomes.Add("Luis");
            nomes.Add("Luis");
            nomes.Add("Luis");
            nomes.Add("Luis");
            nomes.Add("Luis");
            nomes.Add("Luis");
            nomes.Add("Luis");
            nomes.Add("Luis");

            int contador = 0;
            while (contador < nomes.Count)
            {
                Console.WriteLine("O nome é " + nomes[contador]);
                contador++;
            }
            Console.ReadKey();
        }
        void repeticao()
        {
            //Repetições (loop)

            int contador = 0;

            while (contador < 5)
            {
                Console.WriteLine("Olá");
                //formas  de realizar repetição
                contador = contador + 1;
                contador += 1;
                contador++;
            }
            Console.ReadKey();
        }
    }
}