using System;

namespace Atividade1_BIM2
{
    internal class ProgramBase
    {
        private int ConverteData(int mes)
        {



            string[] mes_extenso = new string[12] { "Janeiro", "Fevereiro", "Março",
            "Abril", "Maio", "Junho", "Julho","Agosto","Setembro","Outubro","Novembro", "Dezembro"};

            //aqui será mostrado o mês em extenso, onde pegamos o valor da variavel mês e subtraimos por 1, para localizar a posição no array.
            Console.WriteLine(mes_extenso[mes - 1]);
        }
    }
}