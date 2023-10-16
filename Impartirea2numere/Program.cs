namespace Impartirea2numere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int deimpartit = int.Parse(Console.ReadLine());
            int impartitor = int.Parse(Console.ReadLine());

            if (impartitor != 0)
            {
                if (deimpartit % impartitor == 0)
                {
                    Console.WriteLine(deimpartit / impartitor);
                }
                else
                {
                    Console.WriteLine("Impartirea nu se poate efectua in mod exact");
                }
            }
            else
            {
                Console.WriteLine("Impartirea la 0 nu este posibila");
            }


        }
    }
}