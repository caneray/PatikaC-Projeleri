namespace OrtalamaHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c;
            Console.Write("Derinlik: ");
            int derinlik = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < derinlik; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
        }
    }
}