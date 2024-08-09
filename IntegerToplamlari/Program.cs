namespace IntegerToplamlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen sayı ikililerini boşlukla ayırarak giriniz:");
            string input = Console.ReadLine();

            // Girilen string'i integer dizisine çevirme
            string[] inputArray = input.Split(' ');
            int[] numbers = new int[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                numbers[i] = int.Parse(inputArray[i]);

            }

            // İkilileri inceleyerek toplam veya karenin hesaplanması
            for (int i = 0; i < numbers.Length; i += 2)
            {
                int sum = numbers[i] + numbers[i + 1];
                if (numbers[i] == numbers[i + 1])
                {
                    Console.Write(sum * sum + " ");

                }
                else
                {
                    Console.Write(sum + " ");
                }
            }
        }
    }
}
