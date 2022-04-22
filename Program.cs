using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine("|  Menu Interativo: Tabuada  |");
            Console.WriteLine("------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Escolha uma das 4 operções matemáticas abaixo:");
            Console.WriteLine("1- Adição");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisão");
            Console.WriteLine("5- Sair");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("");
            var esc = int.Parse(Console.ReadLine());

            switch (esc)
            {
                case 1: Adicao(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: Saida(); break;
                default: Menu(); break;

            }



        }

        static void Adicao()
        {
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine("|  Menu Interativo: Tabuada  |");
            Console.WriteLine("------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Escolha um número: ");
            var n1 = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("--------Tabuada Adição--------");
            for (double i = 1; i <= 10; i++)
            {
                double res = n1 + i;
                Console.WriteLine($"  {n1}  +  {i}  =  {res}");
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu.");
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine("|  Menu Interativo: Tabuada  |");
            Console.WriteLine("------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Escolha um número: ");
            var n1 = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("--------Tabuada Subtração--------");
            for (double i = 1; i <= 10; i++)
            {
                double res = n1 - i;
                Console.WriteLine($"  {n1}  -  {i}  =  {res}");
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu.");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine("|  Menu Interativo: Tabuada  |");
            Console.WriteLine("------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Escolha um número: ");
            var n1 = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("--------Tabuada Multiplicação--------");
            for (double i = 1; i <= 10; i++)
            {
                double res = n1 * i;
                Console.WriteLine($"  {n1}  X  {i}  =  {res}");
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu.");
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine("|  Menu Interativo: Tabuada  |");
            Console.WriteLine("------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Escolha um número: ");
            var n1 = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("--------Tabuada Divisão--------");
            for (double i = 1; i <= 10; i++)
            {
                double res = n1 / i;
                Console.WriteLine($"  {n1}  /  {i}  =  {res}");
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu.");
            Console.ReadKey();
            Menu();
        }

        static void Saida()
        {
            Console.Clear();
            Console.WriteLine("--------------------");
            Console.WriteLine("Programa Finalizado.");
            Console.WriteLine("--------------------");
            System.Environment.Exit(0);
        }
    }

}
