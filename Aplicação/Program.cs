using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu();
        }




        void menu()
        {
            Console.WriteLine("Olá, qual operação deseja fazer?");
            Console.ReadLine();
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão\n");
            Console.WriteLine("Por favor, digite o numero da opção que deseja:");

            opcoes();
            int num = int.Parse(Console.ReadLine());

        }


        void opcoes()
        {
            switch (num)
            {
                case 1:
                    Console.WriteLine("Você Escolheu a adição!");
                    Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("Você Escolheu a Subtração");
                    break;

                case 3:
                    Console.WriteLine("Você Escolheu a Multiplicação");
                    break;

                case 4:
                    Console.WriteLine("Você Escolheu a divisão");
                    break;

                default:
                    Console.WriteLine("Não foi possivel escolher a sua opção, desculpe.");
                    break;
            }
        }
    }
}
