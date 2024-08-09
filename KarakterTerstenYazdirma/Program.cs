namespace KarakterTerstenYazdirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("String Degeri Giriniz: ");
            string strDeger = Console.ReadLine();
            int harfSayisi = strDeger.Count();
            for (int i = 1; i<= harfSayisi; i++)
            {
                Console.Write(strDeger[harfSayisi-i]);
            }
        }
    }
}