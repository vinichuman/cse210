using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira uma lista de números e digite 0 quando terminar.");
        
        List<int> numeros = new List<int>();
        int numero;

        // Pedir números até que insira 0
        do
        {
            Console.Write("Insira o número: ");
            string input = Console.ReadLine();
            numero = int.Parse(input);

            if (numero != 0)
            {
                numeros.Add(numero);
            }

        } while (numero != 0);

        if (numeros.Count > 0)
        {
            // 1. Calcular a soma
            int soma = 0;
            foreach (int n in numeros)
            {
                soma += n;
            }
            Console.WriteLine($"A soma é: {soma}");

            // 2. Calcular a média
            double media = (double)soma / numeros.Count;
            Console.WriteLine($"A média é: {media}");

            // 3. Encontrar o maior número
            int maior = numeros[0];
            foreach (int n in numeros)
            {
                if (n > maior)
                {
                    maior = n;
                }
            }
            Console.WriteLine($"O maior número é: {maior}");

            // Menor número positivo
            int menorPositivo = int.MaxValue;
            bool encontrouPositivo = false;
            
            foreach (int n in numeros)
            {
                if (n > 0 && n < menorPositivo)
                {
                    menorPositivo = n;
                    encontrouPositivo = true;
                }
            }
            
            if (encontrouPositivo)
            {
                Console.WriteLine($"O menor número positivo é: {menorPositivo}");
            }

            // Ordenar e exibir a nova lista
            numeros.Sort();
            Console.WriteLine("A lista reordenada é:");
            foreach (int n in numeros)
            {
                Console.WriteLine(n);
            }
        }
    }
}