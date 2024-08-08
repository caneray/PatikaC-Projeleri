namespace DaireCizme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dairenin Yaricapini Girin: ");
            int radius = Convert.ToInt32(Console.ReadLine());
            double thickness = 0.4; // Daire çizgisi kalınlığı
            char symbol = '*'; // Daireyi çizeceğimiz karakter

            Console.Clear();
            double rIn = radius - thickness, rOut = radius + thickness;

            for (int y = radius; y >= -radius; --y)
            {
                for (int x = -radius; x < rOut; x += 2)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}