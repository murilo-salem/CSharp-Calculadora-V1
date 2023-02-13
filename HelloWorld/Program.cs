using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        enum Operações { Somar, Subtrair, Multiplicar, Dividir };

        static void Main(string[] args)
        {
            
            Console.WriteLine("Bem-vindo a calculadora 20XX!");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".\n");

            Console.WriteLine("Insira aqui o primeiro valor:\n");
            int numA = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInsira aqui o segundo valor:\n");
            int numB = int.Parse(Console.ReadLine());
            Console.WriteLine("\nSó para checar, os número escolhidos foram " + numA + " e " + numB + ".");

            Console.WriteLine("\nSua opções são: \n");
            Console.WriteLine("1 -> Soma\n2 -> Subtração\n3 -> Multiplicação\n4 -> Divisão\n");
            int selectedMathOption = int.Parse(Console.ReadLine());
            

            if (selectedMathOption == 1)
            {
                Console.WriteLine("\nOkay, você escolheu a opção SOMA. \n");
                Console.WriteLine("O resultado é: " + (numA + numB) + ".\n");
            } else if (selectedMathOption == 2)
            {
                Console.WriteLine("\nOkay, você escolheu a opção SUBTRAÇÃO. \n");
                Console.WriteLine("O resultado é: " + (numA - numB) + ".\n");
            } else if (selectedMathOption == 3)
            {
                Console.WriteLine("\nOkay, você escolheu a opção MULTIPLICAÇÃO. \n");
                Console.WriteLine("O resultado é: " + (numA * numB) + ".\n");
            } else if (selectedMathOption == 4)
            {
                Console.WriteLine("\nOkay, você escolheu a opção DIVISÃO. \n");
                Console.WriteLine("O resultado é: " + (numA / numB) + ".\n");
            }

            Console.ReadLine();
        }
    }
}

