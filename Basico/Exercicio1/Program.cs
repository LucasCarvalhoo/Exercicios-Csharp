namespace Myapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estoque medio de peças");
            Console.WriteLine("============================\n");

            Console.Write("Quantidade Minima: ");
            int quantidadeMinima = int.Parse(Console.ReadLine());

            Console.Write("Quantidade Maxima: ");
            int quantidadeMaxima = int.Parse(Console.ReadLine());

            int estoqueMedio = (quantidadeMinima + quantidadeMaxima) / 2;

            Console.WriteLine($"Estoque Medio: {estoqueMedio}");
        }
    }
}
