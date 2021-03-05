using System;

namespace Calculator
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
            Console.WriteLine("--------- Escolha uma Opção do Menu ---------");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("------------------");
            Console.WriteLine("Selecione uma Opção");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                default: Menu(); break;
            }

        }
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor da Soma");
            float v1 = float.Parse(Console.ReadLine());


            Console.WriteLine("Segundo Valor");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v2 + v1;
            Console.WriteLine($"O Resultado da Soma {resultado}");
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor Subtração");
            float v1 = float.Parse(Console.ReadLine());


            Console.WriteLine("Segundo Valor");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v2 - v1;
            Console.WriteLine($"O Resultado da Subtração {resultado}");

            Console.WriteLine("");
        }


        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor da Divisão");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Segundo Valor");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;
            Console.Write($"O Resultado da Divisão é {resultado}");



        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor da Multiplicação");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Segundo Valor");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;
            Console.Write($"O Resultado da Multiplicação é {resultado}");



        }
    }
}
