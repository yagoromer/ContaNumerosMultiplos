using System;

namespace ProjetoYago
{
    class Program
    {
        static void Main(string[] args)
        {
            inicio:
            Console.WriteLine("Informe um numero para fazer a soma");
            int soma = int.Parse(Console.ReadLine());
            //int mod = 11 - (soma % 11);

            while (soma < 200)
            {
                int soma2 = soma;
                if (soma % 3 == 0 && soma % 5 == 0)
                {
                    Console.WriteLine("A soma do numero "+soma+ " + "+soma2+" multiplos de 3 e 5 é: ....." + soma2);
                    soma++;
                }
                else
                {
                    soma++;
                }

            }
            Console.WriteLine("- Digite 1 para voltar ao inicio do programa, ou pressione a tecla 'Enter' para fechar o programa");
            string recebeResposta = Console.ReadLine();
            if(recebeResposta == "1")
            {
                goto inicio;
            }
            
        }
    }
}
