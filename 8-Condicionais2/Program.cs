using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 8 - Condicionais 2");

            int idade = 18;
            //int numeroPessoas = 2;
            bool acompanhado = true;

            //bool acompanhado = numeroPessoas >= 2; //variável booleana (true ou false)

            // Verificar se a idade é maior ou não de 16 anos e (&&) se está acompanhado ou não.

            if (idade >= 18 && acompanhado == true) 
            {
                Console.WriteLine("Pode entrar!");
            }
            else 
            {
                Console.WriteLine("Não pode entrar!");
            }

            Console.ReadLine();
        }
    }
}
