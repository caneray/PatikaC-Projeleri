namespace SessizHarf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kelimeyi veya Kelimeleri Giriniz: ");
            string input = Console.ReadLine();

            // Split the input string into words
            string[] words = input.Split(' ');

            // Define the set of consonants
            string sessizHarfler = "bcçdfgğhjklmnprsştvyzBCÇDFGĞHJKLMNPRSŞTVYZ";

            // Process each word
            foreach (string word in words)
            {
                bool yanYanaSessizHarfVarMi = false;

                // Check each character in the word
                for (int i = 0; i < word.Length - 1; i++)
                {
                    if (sessizHarfler.Contains(word[i]) && sessizHarfler.Contains(word[i + 1]))
                    {
                        yanYanaSessizHarfVarMi = true;
                        break;
                    }
                }

                // Output the result for the current word
                Console.Write(yanYanaSessizHarfVarMi + " ");
            }

        }
    }
}