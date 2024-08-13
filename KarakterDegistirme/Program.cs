namespace KarakterDegistirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kelimeyi Giriniz: ");
            string input = Console.ReadLine();

            // Split the input string into words
            string[] words = input.Split(' ');

            // Process each word
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                // If the word has more than one character, swap the first and last characters
                if (word.Length > 1)
                {
                    char firstChar = word[0];
                    char lastChar = word[word.Length - 1];

                    // Reconstruct the word with swapped first and last characters
                    words[i] = lastChar + word.Substring(1, word.Length - 2) + firstChar;
                }
            }

            // Join the processed words back into a single string
            string result = string.Join(" ", words);

            // Output the result
            Console.WriteLine(result);
        }
    }
}