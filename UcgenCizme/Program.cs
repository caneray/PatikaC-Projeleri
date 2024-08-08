namespace UcgenCizme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Üçgenin Boyutunu Giriniz: ");
            int boyut = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i <= boyut; i++) 
            {
                for (int j = i; j <= boyut; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write("/");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}