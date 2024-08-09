namespace AlanHesaplama
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Şekli Giriniz(Daire,Kare,Dikdörtgen,Üçgen): ");
            string Sekil = Console.ReadLine();

            switch (Sekil)
            {
                case "Daire":
                    Console.Write("Dairenin Yarıçapını Giriniz: ");
                    int daireYaricap = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Dairenin Çevresi : " + 2* Math.PI * daireYaricap);
                    Console.WriteLine("Dairenin Alanı : " + Math.PI*Math.Pow(daireYaricap, 2));
                    break;
                case "Kare":
                    Console.Write("Karenin Kenar Uzunluğunu Giriniz: ");
                    int kareBoyut = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Karenin Çevresi : " + 4 * kareBoyut);
                    Console.WriteLine("Karenin Alanı : " + Math.Pow(kareBoyut, 2));
                    break;
                case "Dikdörtgen":
                    Console.Write("Dikdörtgenin Uzun Kenarını Giriniz: ");
                    int uzunKenar = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Dikdörtgenin Kısa Kenarını Giriniz: ");
                    int kisaKenar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Dikdörtgenin Çevresi : " + (2 * uzunKenar + 2*kisaKenar));
                    Console.WriteLine("Dikdörtgenin Alanı : " + uzunKenar*kisaKenar);
                    break;
                case "Üçgen":
                    Console.Write("Üçgenin Kenar Uzunluğunu Giriniz: ");
                    int kenarUzunlugu = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Üçgenin Çevresi : " + (kenarUzunlugu * 3));
                    Console.WriteLine("Üçgenin Alanı : " + (Math.Sqrt(3) / 4)*Math.Pow(kenarUzunlugu,2));
                    Console.WriteLine("NOT: Üçgenin hesaplanmasında eşkenar üçgen olduğu varsayılmıştır!");
                    break;
            }
        }
    }
    

}