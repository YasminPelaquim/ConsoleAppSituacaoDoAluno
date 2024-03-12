using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSituacaoDoAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a média do aluno? : ");
            double m = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o percentual(%) de presença do aluno? : ");
            double p = double.Parse(Console.ReadLine());

            if (m >= 7 && p >= 75)
            {
                Console.WriteLine("Situação: APROVADO.");
            } else if (m < 7 && m >= 4 && p >= 75 || m >= 7 && p < 75)
            {
                Console.WriteLine("Situação: RECUPERAÇÃO.");
            } else  
            {
                Console.WriteLine("Situação: RETIDO.");
            } 

            Console.ReadKey();






        }
    }
}
