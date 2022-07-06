using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Atividade1_BIM2
{
    internal class Program
    {
        
            /* |====================================================| */
            /* |* AUTOR: RENAN LIMA | RA: 6321300 ******************| */
            /* |* DATA DE CRIAÇÃO: 06.JUL.2022 *********************| */
            /* |* PROVA FECHAMENTO DE NOTA DO 2 BIMESTRE ***********| */
            /* |* MATÉRIA: LÓGICA DE PROGRAMAÇÃO *******************| */
            /* |* SEMESTRE: 1 | INSTITUIÇÃO: UNIFAAT ATIBAIA *******| */
            /* |* CURSO: ANÁLISE E DESENVOLVIMENTO DE SISTEMAS *****| */
            /* |====================================================| */


        static void Main(string[] args)
        {


            string aluno; double p1, p2, trab;

            Console.Write("Olá! por favor, insira seu primeiro e último nome: ");
            aluno = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("|=== Bem-Vindo " + aluno + " =)");
            Console.WriteLine("|---------------------------------------------------------|");
            Console.Write("\nFavor, insira a nota da Primeira Prova: ");
            p1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Agora, insira a nota da Segunda Prova: ");
            p2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira a nota do Trabalho: ");
            trab = Convert.ToDouble(Console.ReadLine());

            if ((p1 < 0 || p1 > 10) || (p2 < 0 || p2 > 10) || (trab < 0 || trab > 10))
            {

                Console.WriteLine("Por favor, insira uma nota válida! Não será permitido valores menores que 0 ou maiores que 10");
                Console.ReadKey();
            }

            else
            {
                double media = (p1 + p2 + trab) / 3;

                if (media >= 8.5)
                {

                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine("Parabéns " + aluno + "! Sua média foi de " + media + "\nConceito: A");
                    Console.ReadKey();

                }

                else if (media >= 7 && media < 8.5)
                {
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine("Muito bem " + aluno + "! Sua média foi de " + media + "\nConceito: B");
                    Console.ReadKey();

                }

                else if (media >= 6 && media < 7)
                {
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine(aluno + ", você pode melhorar! Sua média foi de " + media + "\nConceito: C");
                    Console.ReadKey();
                }

                else if (media >= 0.1 && media < 6)
                {
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine(aluno + ", sua média foi de " + media + "\nConceito: D");
                    Console.ReadKey();
                }

                else if (media == 0)
                {
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine(aluno + ", infelizmente sua média foi " + media + "\nConceito: E");
                    Console.ReadKey();
                }

            }

        }
    }        
     
}

