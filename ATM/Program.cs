namespace ATM
{
    internal class Program
    {
        static Dictionary<string, int> hesaplar = new Dictionary<string, int>
    {
        { "user1", 5000 },
        { "user2", 10000 },
        { "user3", 7500 }
    };
        static List<string> transactionLog = new List<string>();
        static List<string> hataLog = new List<string>();

        static void Main()
        {
            bool devam = true;

            while (devam)
            {
                Console.WriteLine("Kullanıcı adı girin:");
                string kullaniciAdi = Console.ReadLine();

                if (!hesaplar.ContainsKey(kullaniciAdi))
                {
                    Console.WriteLine("Geçersiz kullanıcı adı.");
                    hataLog.Add($"Hatalı giriş denemesi: {kullaniciAdi}, {DateTime.Now}");
                    continue;
                }

                Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
                Console.WriteLine("1. Para Çekme");
                Console.WriteLine("2. Para Yatırma");
                Console.WriteLine("3. Ödeme Yapma");
                Console.WriteLine("4. Gün Sonu");

                int secim = int.Parse(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        ParaCekme(kullaniciAdi);
                        break;
                    case 2:
                        ParaYatirma(kullaniciAdi);
                        break;
                    case 3:
                        OdemeYapma(kullaniciAdi);
                        break;
                    case 4:
                        GunSonu();
                        devam = false;
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim.");
                        break;
                }
            }
        }

        static void ParaCekme(string kullaniciAdi)
        {
            Console.WriteLine("Çekmek istediğiniz miktarı girin:");
            int miktar = int.Parse(Console.ReadLine());

            if (hesaplar[kullaniciAdi] >= miktar)
            {
                hesaplar[kullaniciAdi] -= miktar;
                Console.WriteLine($"Başarılı. Yeni bakiyeniz: {hesaplar[kullaniciAdi]}");
                transactionLog.Add($"Para Çekme - Kullanıcı: {kullaniciAdi}, Miktar: {miktar}, Tarih: {DateTime.Now}");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye.");
                hataLog.Add($"Yetersiz bakiye - Kullanıcı: {kullaniciAdi}, Miktar: {miktar}, Tarih: {DateTime.Now}");
            }
        }

        static void ParaYatirma(string kullaniciAdi)
        {
            Console.WriteLine("Yatırmak istediğiniz miktarı girin:");
            int miktar = int.Parse(Console.ReadLine());

            hesaplar[kullaniciAdi] += miktar;
            Console.WriteLine($"Başarılı. Yeni bakiyeniz: {hesaplar[kullaniciAdi]}");
            transactionLog.Add($"Para Yatırma - Kullanıcı: {kullaniciAdi}, Miktar: {miktar}, Tarih: {DateTime.Now}");
        }

        static void OdemeYapma(string kullaniciAdi)
        {
            Console.WriteLine("Ödeme yapmak istediğiniz miktarı girin:");
            int miktar = int.Parse(Console.ReadLine());

            if (hesaplar[kullaniciAdi] >= miktar)
            {
                hesaplar[kullaniciAdi] -= miktar;
                Console.WriteLine($"Başarılı. Yeni bakiyeniz: {hesaplar[kullaniciAdi]}");
                transactionLog.Add($"Ödeme Yapma - Kullanıcı: {kullaniciAdi}, Miktar: {miktar}, Tarih: {DateTime.Now}");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye.");
                hataLog.Add($"Yetersiz bakiye - Kullanıcı: {kullaniciAdi}, Miktar: {miktar}, Tarih: {DateTime.Now}");
            }
        }

        static void GunSonu()
        {
            string dosyaAdi = $"EOD_{DateTime.Now.ToString("ddMMyyyy")}.txt";
            using (StreamWriter sw = new StreamWriter(dosyaAdi))
            {
                sw.WriteLine("Gün Sonu Raporu");
                sw.WriteLine("=================");
                sw.WriteLine("İşlemler:");
                foreach (string log in transactionLog)
                {
                    sw.WriteLine(log);
                }

                sw.WriteLine("\nHatalı Giriş Denemeleri:");
                foreach (string log in hataLog)
                {
                    sw.WriteLine(log);
                }
            }

            Console.WriteLine($"Gün sonu raporu {dosyaAdi} dosyasına yazıldı.");
        }
    }
}