namespace Voting
{
    internal class Program
    {
        static Dictionary<string, int> oylar = new Dictionary<string, int>();
        static List<string> kategoriler = new List<string> { "Film Kategorileri", "Tech Stack Kategorileri", "Spor Kategorileri" };
        static Dictionary<string, HashSet<string>> kullaniciOylar = new Dictionary<string, HashSet<string>>();
        static void Main(string[] args)
        {
            bool devam = true;

            while (devam)
            {
                Console.WriteLine("Kullanıcı adı girin:");
                string kullaniciAdi = Console.ReadLine();

                // Kullanıcı sistemde kayıtlı mı kontrol et
                if (!kullaniciOylar.ContainsKey(kullaniciAdi))
                {
                    Console.WriteLine("Kayıtlı değilsiniz. Şimdi kayıt olmak ister misiniz? (e/h)");
                    string cevap = Console.ReadLine().ToLower();

                    if (cevap == "e")
                    {
                        // Kayıt işlemi
                        kullaniciOylar[kullaniciAdi] = new HashSet<string>();
                        Console.WriteLine("Kayıt başarılı! Şimdi oy kullanabilirsiniz.");
                    }
                    else
                    {
                        Console.WriteLine("Oylama işlemi iptal edildi.");
                        continue; // Döngünün başına dön ve yeni bir kullanıcı adı al
                    }
                }

                Console.WriteLine("Lütfen bir kategori seçin ve oy verin:");

                for (int i = 0; i < kategoriler.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {kategoriler[i]}");
                }

                int secim;
                bool gecerliSecim = int.TryParse(Console.ReadLine(), out secim) && secim > 0 && secim <= kategoriler.Count;

                if (gecerliSecim)
                {
                    string secilenKategori = kategoriler[secim - 1];

                    if (kullaniciOylar[kullaniciAdi].Contains(secilenKategori))
                    {
                        Console.WriteLine("Bu kategoriye zaten oy verdiniz.");
                    }
                    else
                    {
                        kullaniciOylar[kullaniciAdi].Add(secilenKategori);
                        if (!oylar.ContainsKey(secilenKategori))
                        {
                            oylar[secilenKategori] = 0;
                        }
                        oylar[secilenKategori]++;
                        Console.WriteLine($"{secilenKategori} kategorisine oy verdiniz.");
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
                }

                Console.WriteLine("Başka bir kullanıcı oy vermek ister mi? (e/h)");
                devam = Console.ReadLine().ToLower() == "e";
            }

            SonuclariGoster();
        }
        static void SonuclariGoster()
        {
            Console.WriteLine("\nOylama Sonuçları:");
            int toplamOy = oylar.Values.Sum();

            foreach (var kategori in kategoriler)
            {
                int kategoriOyu = oylar.ContainsKey(kategori) ? oylar[kategori] : 0;
                double yuzde = toplamOy > 0 ? (kategoriOyu / (double)toplamOy) * 100 : 0;
                Console.WriteLine($"{kategori}: {kategoriOyu} oy (%{yuzde:F2})");
            }
        }
    }
}