using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, i, n, s,si,sp, d, menor,maior;

            Console.WriteLine("=====MENU=====");
            Console.WriteLine("1- Exercício 1");
            Console.WriteLine("2- Exercício 2");
            Console.WriteLine("3- Exercício 3");
            Console.WriteLine("4- Exercício 4");
            Console.WriteLine("5- Exercício 5");
            Console.WriteLine("6- Exercício 6");
            Console.WriteLine("7- Exercício 7");
            Console.WriteLine("Digite a opção desejada: ");

            num = int.Parse(Console.ReadLine());

            switch(num)
            {
                case 1:
                    //atividade 1
                    //int n;

                    Console.WriteLine("Digite um valor qualquer: ");
                    n = int.Parse(Console.ReadLine());

                    for ( i = 0; i <= n; i++)
                    {
                        Console.WriteLine("" + i);
                    }
                    Console.ReadKey();
                    break;

                case 2:
                    //atividade 2
                    //int n, i;

                    Console.WriteLine("Digite um valor qualquer: ");
                    n = int.Parse(Console.ReadLine());

                    for (i = 1; i <= n; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine("" + i);
                        }
                    }
                    Console.ReadKey();
                    break; 

                case 3:

                    //atividade 3

                    //int i, n;

                    Console.WriteLine("Digite um valor qualquer abaixo de 1000: ");
                    n = int.Parse(Console.ReadLine());

                    for (i = n; i <= 1000; i++)
                    {
                        if (n > i)
                        {
                            Console.WriteLine("Valor inválido");

                        }
                        else if (i % 2 == 0)
                        {
                            Console.WriteLine("" + i);
                        }
                    }
                    Console.ReadKey();
                    break;

                case 4:
                    //atividade 4
                    //int , i;
                    s = 0;
                    for (; s < 200;)
                    {
                        Console.WriteLine("Digite um valor qualquer: ");
                        i = int.Parse(Console.ReadLine());

                        if (i > 0)
                        {
                            s += 1;

                        }
                    }
                    Console.ReadKey();
                    break; 

                case 5:
                    //atividade 5
                    //int i, d;

                    Console.WriteLine("Digite um valor qualquer: ");
                    i=int.Parse(Console.ReadLine());
                    d = 1;

                    for(; i % d == 0; d++)
                    {
                        Console.WriteLine("" + d );
                    }
                    Console.ReadKey();

                    break;

                case 6:
                    Console.WriteLine("Digite um valor qualquer: ");
                    n=int.Parse(Console.ReadLine());

                    menor = n;
                    maior = n;

                    for (i = 0; i < 9; i++)
                    {
                        Console.WriteLine("Digite um valor: ");
                        n= int.Parse(Console.ReadLine());

                        if (n< menor)
                        {
                            menor = n;

                        }
                        else if (n > maior)
                        {
                            maior = n;
                        }

                        Console.WriteLine("Maior: " + maior);
                        Console.WriteLine("Menor: " + menor);
                        Console.ReadKey();
                    }
                    break;

                case 7:
                    n = 1;
                    si = 0;
                    sp = 0;

                    for(; n != 0;)
                    {
                        Console.WriteLine("Digite um valor diferente de 0: ");
                        n= int.Parse(Console.ReadLine());

                        if (n % 2 == 0)
                        {
                            sp = sp + n;

                        }
                        else
                        {
                            si= si + n; 
                        }

                        Console.WriteLine("Soma dos Pares: " +sp);
                        Console.WriteLine("Soma dos Ímpares: " +si);
                        Console.ReadKey();
                    }
                    break;

            }














         























        }
    }
}
