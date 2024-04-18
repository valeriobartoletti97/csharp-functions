namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FUNZIONI DI UTILITY

            void StampaArray(int[] array)
            {
                Console.Write("(");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i]);
                    if (i < array.Length - 1)
                        Console.Write(", ");
                }
                Console.WriteLine(") ");
            }

            int Quadrato(int numero)
            {
                int newNumber = numero * numero;
                return newNumber;
                
            }

            int[] ElevaArrayAlQuadrato(int[] array)
            {
                int[] newArray = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = array[i] * array[i];
                }
                return newArray;
            }

            int sommaElementiArray(int[] array)
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                return sum;
            }

            int[] myArray = { 2, 6, 7, 5, 3, 9 };
            StampaArray(myArray);
            StampaArray(ElevaArrayAlQuadrato(myArray));
            StampaArray(myArray);
            Console.WriteLine($"La somma di tutti i numeri del primo array è: {sommaElementiArray(myArray)}");
            Console.WriteLine($"La somma di tutti i numeri elevati al quadrato è: {sommaElementiArray(ElevaArrayAlQuadrato(myArray))}");
        }
    }
}
