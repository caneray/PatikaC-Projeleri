namespace Algoritma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("String ve Sayi giriniz (ex: Algoritma,5) : ");
            string degisken = Console.ReadLine();
            string stringDeger = degisken.Split(',')[0];
            int indexDegeri = Convert.ToInt32(degisken.Split(',')[1]);
            try
            {
                Console.WriteLine(stringDeger.Remove(indexDegeri, 1));
            }
            catch
            {
                Console.WriteLine(stringDeger);
            }

            
        }
    }
}