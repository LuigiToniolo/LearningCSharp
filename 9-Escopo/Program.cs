using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 9 - Escopo");

            int idade = 19;
            bool acompanhado = true;
            string mensagemAdicional;

            // Verificar se a idade é maior ou não de 16 anos e (&&) se está acompanhado ou não.

            if(acompanhado == true)
            {
                mensagemAdicional = "João está acompanhado!";
            }
            else
            {
                mensagemAdicional = "João não está acompanhado";
            }


            if (idade >= 18 && acompanhado == true)
            {
                Console.WriteLine("Pode entrar!");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar!");
            }

            Console.ReadLine();
        }
    }
}
