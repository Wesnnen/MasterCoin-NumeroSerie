using System;
using System.Text.RegularExpressions;
class Program
{
    // Método para incrementar o número de série completo
    static string IncrementarSequencia(string sequencia)
    {
        char[] caracteres = sequencia.ToCharArray();
        for (int i = caracteres.Length - 1; i >= 0; i--)
        {
            if (caracteres[i] == 'Z') // Se for 'Z', vira '0' e continua para a próxima posição
            {
                caracteres[i] = '0';
            }
            else if (caracteres[i] == '9') // Se for '9', vira 'A'
            {
                caracteres[i] = 'A';
                return new string(caracteres);
            }
            else if (caracteres[i] >= '0' && caracteres[i] < '9') // Incrementa números
            {
                caracteres[i]++;
                return new string(caracteres);
            }
            else if (caracteres[i] >= 'A' && caracteres[i] < 'Z') // Incrementa letras
            {
                caracteres[i]++;
                return new string(caracteres);
            }
        }

        // Se todas as posições transbordarem, reinicia como '0'
        return new string('0', caracteres.Length);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("=== Gerador de Sequências de Número de Série ===");

        Console.Write("Digite o número de série inicial: ");
        string numeroSerie = Console.ReadLine().ToUpper();

        if (!Regex.IsMatch(numeroSerie, @"^[A-Za-z0-9]+$"))
        {
            Console.WriteLine("Erro: O número de série deve conter apenas letras e números!");
            return;
        }

        Console.Write("Digite a quantidade de novas sequências a serem geradas: ");
        if (!int.TryParse(Console.ReadLine(), out int quantidade) || quantidade <= 0)
        {
            Console.WriteLine("Erro: A quantidade deve ser um número inteiro positivo!");
            return;
        }

        Console.WriteLine("\n=== Sequências Geradas ===");

        string sequenciaAtual = numeroSerie;
        for (int i = 0; i < quantidade; i++)
        {
            // Incrementa a sequência para a próxima iteração
            sequenciaAtual = IncrementarSequencia(sequenciaAtual);

            Console.WriteLine(sequenciaAtual);
        }

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}