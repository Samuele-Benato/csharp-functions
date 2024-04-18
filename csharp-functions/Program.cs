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

            void PrintArray(string[] array)
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
            PrintArray(elements);

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

            /*
            3. int[] ElevaArrayAlQuadrato(int[] array)
            che preso un array di numeri interi, 
            restituisca un nuovo array con tutti gli elementi elevati quadrato.
            */

            Console.WriteLine("-----INIZIO TERZA FUNCTION-----");

            int[] SquareArrayElements(int[] array)
            {
                int[] squaredArray = new int[array.Length]; // creo un nuovo array per non modificare l'originale

                for(int i = 0;i < squaredArray.Length; i++)
                {
                    squaredArray[i] = array[i] * array[i]; // elevo gli elementi al quadrato
                }

                return squaredArray;
            }

            int[] myArray = { 4, 6, 7, 9, 10, 12 };
            int[] squaredMyArray = SquareArrayElements(myArray);

            // Visualizzo l'array originale
            Console.Write("L'array originale è: ");
            foreach (int num in myArray)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            // Visualizzo l'array al quadrato
            Console.Write("L'array al quadrato è: ");
            foreach (int num in squaredMyArray)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
            Console.WriteLine("-----FINE TERZA FUNCTION-----");

            /*
            4. int sommaElementiArray(int[] array)
            preso un array di numeri interi, 
            restituisca la somma totale di tutti gli elementi dell’array.
            */

            Console.WriteLine("-----INIZIO QUARTA FUNCTION-----");

            int SumArrayElements(int[] array)
            {
                int sum = 0;

               for(int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
               return sum;
            }

            int[] myArray2 = { 4, 6, 7, 9, 10, 12 };
            int sumMyArray2 = SumArrayElements(myArray2);

            Console.WriteLine($"La somma di tutti gli elementi dell'array è {sumMyArray2}");

            Console.WriteLine("-----FINE QUARTA FUNCTION-----");

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("RICHIESTE TRACCIA");
            int[] slackArray = { 2, 6, 7, 5, 3, 9 };

            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("");

            //Stampare l’array di numeri fornito a video
            Console.Write("Array Slack: ");
            foreach (int num in slackArray)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("");

            //Stampare l’array di numeri fornito a video,
            //dove ogni numero è stato prima elevato al quadrato
            //(Verificare che l’array originale non sia stato modificato quindi
            //ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])
            int[] squaredSlackArray = SquareArrayElements(slackArray);

            // Visualizzo l'array originale
            Console.Write("L'array originale Slack è: ");
            foreach (int num in slackArray)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            // Visualizzo l'array al quadrato
            Console.Write("L'array al quadrato Slack è: ");
            foreach (int num in squaredSlackArray)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("");

            //Stampare la somma di tutti i numeri
            int sumSlackArray = SumArrayElements(slackArray);
            Console.WriteLine($"La somma di tutti gli elementi dell'array Slack è {sumSlackArray}");

            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("");

            //Stampare la somma di tutti i numeri elevati al quadrati

            int[] squaredSlackArray2 = SquareArrayElements(slackArray);
            int sumSlackSquaredArray = SumArrayElements(squaredSlackArray2);

            Console.WriteLine($"La somma di tutti gli elementi dell'array Slack al quadrato è {sumSlackSquaredArray}");

            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------");
        }
    }
}
