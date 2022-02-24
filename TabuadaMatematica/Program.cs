using System;

namespace TabuadaMatematica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa Tabuada");
            Console.WriteLine();
            Inicio:
            Console.WriteLine("Escolha a opção de tabuada que deseja realizar:");
            Console.WriteLine();
            Console.WriteLine("Digite 1 para Soma: ");
            Console.WriteLine("Digite 2 para Subtração: ");
            Console.WriteLine("Digite 3 para Multiplicação: ");
            Console.WriteLine("Digite 4 para Divisão: ");
            Console.Write("Opção Selecionada: ");
            int resposta = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (resposta)
            {
                case 1:
                    Console.Write("Entre com o Nº do qual deseja obter a tabuada: ");
                    int n1 = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= n1; i++)
                    {
                        for (int d = 1; d <= 10; d++)
                        {
                            Console.WriteLine($"{i} + {d} = {i + d}");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 2:
                    Console.Write("Entre com o Nº do qual deseja obter a tabuada: ");
                    int n2 = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= n2; i++)
                    {
                        for (int d = 1; d <= 10; d++)
                        {
                            Console.WriteLine($"{i} - {d} = {i - d}");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 3:
                    Console.Write("Entre com o Nº do qual deseja obter a tabuada: ");
                    int n3 = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= n3; i++)
                    {
                        for (int d = 1; d <= 10; d++)
                        {
                            Console.WriteLine($"{i} x {d} = {i * d}");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 4:
                    Console.Write("Entre com o Nº do qual deseja obter a tabuada: ");
                    int n4= int.Parse(Console.ReadLine());
                    for (int i = 1; i <= n4; i++)
                    {
                        for (int d = 1; d <= 10; d++)
                        {
                            Console.WriteLine($"{i} / {d} = {i / d}");
                        }
                        Console.WriteLine();
                    }
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Escolha uma opção valida!");
                    goto Inicio;
            }
            Console.ReadKey();
        }
    }
}
