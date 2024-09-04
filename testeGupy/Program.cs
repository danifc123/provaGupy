using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número a ser verificado: ");
        int numero = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;

        while (b < numero)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }

        if (b == numero || numero == 0)
        {
            Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
        }




        Console.Write("Informe uma string: ");
        string input = Console.ReadLine();

        int countLowerA = 0;
        int countUpperA = 0;

        foreach (char c in input)
        {
            if (c == 'a')
            {
                countLowerA++;
            }
            else if (c == 'A')
            {
                countUpperA++;
            }
        }

        int totalA = countLowerA + countUpperA;

        if (totalA > 0)
        {
            Console.WriteLine($"A letra 'a' (maiúscula ou minúscula) aparece {totalA} vezes na string.");
        }
        else
        {
            Console.WriteLine("A letra 'a' (maiúscula ou minúscula) não aparece na string.");
        }
    }
}
