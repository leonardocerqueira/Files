using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Respostas
{
    class Program
    {
        //////////////////////////////////////////////////////////// QUESTAO 1
        static void questao1()
        {
            int p, r;

            do
            {
                Console.WriteLine("digite o valor de P - Valido apenas 0 e 1");
                p = Convert.ToInt32(Console.ReadLine());
            } while (p != 0 && p != 1);

            do
            {
                Console.WriteLine("digite o valor de R - Valido apenas 0 e 1");
                r = Convert.ToInt32(Console.ReadLine());
            } while (r != 0 && r != 1);

            if (p == 0)
                Console.WriteLine("C");
            else if (r==0)
                Console.WriteLine("B");
            else
                Console.WriteLine("A");
        }




        //////////////////////////////////////////////////////////// QUESTAO 2
        static void questao2()
        {
            int p1, c1, p2, c2;
            Console.WriteLine("digite o valor de P1 e C1");
            p1 = Convert.ToInt32(Console.ReadLine());
            c1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite o valor de P2 e C2");
            p2 = Convert.ToInt32(Console.ReadLine());
            c2 = Convert.ToInt32(Console.ReadLine());

            if(p1*c1 == p2*c2)
                Console.WriteLine("0 - Equilibrada");
            else if (p1 * c1 > p2 * c2)
                Console.WriteLine("-1 - Esquerda");
            else 
                Console.WriteLine("1 - direita");
        }




        //////////////////////////////////////////////////////////// QUESTAO 3
        static void questao3()
        {
            int idade, contA = 0, contR = 0, idadeR = 0, contP = 0, maiorP = 0;
            char opniao;
            int espectadores = 5;
            for (int i = 0; i < espectadores; i++)
            {
                Console.WriteLine("digite sua idade");
                idade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("digite A - otimo, B - Bom, C - Regular, D - Ruim e E - Pessimo");
                opniao = Convert.ToChar(Console.ReadLine());

                if (opniao == 'A' || opniao == 'a')
                    contA++;
                else if (opniao == 'D' || opniao == 'd')
                {
                    idadeR += idade;
                    contR++;
                }
                else if (opniao == 'E' || opniao == 'e')
                {
                    contP++;
                    if (idade > maiorP)
                        maiorP = idade;
                }            
            }

            double media = (double)idadeR / contR;
            double porcent = (double)contP / espectadores * 100;
            Console.WriteLine("A quantidade de respostas ótimas: " + contA);
            Console.WriteLine("A média de idade das pessoas que responderam Ruim  " + media);
            Console.WriteLine("A porcentagem de respostas Péssimo  " + porcent);
            Console.WriteLine("A maior idade que utilizou respostas Péssimo  " + maiorP);
        }




        //////////////////////////////////////////////////////////// MAIN
        static void Main(string[] args)
        {
            //questao1();
            //questao2();
            //questao3();
        }
    }
}
