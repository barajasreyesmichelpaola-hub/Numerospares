namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6 };

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    Console.WriteLine($"Número par: {numeros[i]}");
                }
            }
        }
