using System.Xml.Linq;

namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            1. void StampaArray(int[] array)
            stampa a video il contenuto dell’array in questa forma 
            “[elemento 1, elemento 2, elemento 3, ...]”.
            */

            Console.WriteLine("-----INIZIO PRIMA FUNCTION-----");

            void StampaArray(string[] array)
            {
                Console.Write("[");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i]);
                    if (i < array.Length - 1)
                        Console.Write(", ");
                }
                Console.Write("]");
            }

            string[] elements = { "elemento 1", "elemento 2", "elemento 3" };
            StampaArray(elements);

            Console.WriteLine("");
            Console.WriteLine("-----FINE PRIMA FUNCTION-----");

           /*
           2. int Quadrato(int numero)
           che restituisca il quadrato del numero passato come parametro.
           */

            Console.WriteLine("-----INIZIO SECONDA FUNCTION-----");

            int Square(int number)
            {
                int square = number * number;
                return square;
            }

            int value = 5;
            int result = Square(value);

            Console.WriteLine($"Il quadrato di {value} è {result}");

            Console.WriteLine("-----FINE SECONDA FUNCTION-----");
        }
    }
}
