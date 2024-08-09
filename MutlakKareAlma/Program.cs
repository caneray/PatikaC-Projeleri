namespace MutlakKareAlma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen sayıları giriniz:");
            string input = Console.ReadLine();

            // Girilen string'i integer dizisine çevirme
            string[] inputArray = input.Split(' ');
            int[] numbers = new int[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                numbers[i] = int.Parse(inputArray[i]);

            }
            int buyukToplamlar = 0;
            int kucukToplamlar = 0;

            for (int i = 0;i < numbers.Length; i++)
            {
                if (numbers[i] > 67)
                {
                    buyukToplamlar += (numbers[i] - 67) * (numbers[i] - 67); 
                }
                else if (numbers[i] < 67)
                {
                    kucukToplamlar += 67 - numbers[i];
                }
            }
            Console.WriteLine(kucukToplamlar + " " + buyukToplamlar);

        }
    }
}