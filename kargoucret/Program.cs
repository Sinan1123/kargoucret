namespace kargoucret
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price = 0;

            while (true)
            {
                Console.WriteLine("Kargo ücreti hesaplama uygulamasına hoşgeldiniz!");

                Console.WriteLine("Kargonun gidecegi km yi yazınız:");
                double km =Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Kargonun kaç kg oldugunu yazınız:");

                double kg =Convert.ToDouble(Console.ReadLine());

                if (km <= 0)
                {
                    Console.WriteLine("Km 0 dan küçük veya eşit olamaz!");
                    continue;
                }

                if (kg <= 0)
                {
                    Console.WriteLine("Kargo agırlıgı 0 veya altı olamaz!");
                    continue;
                }
                else
                {
                    price = CargoPrice(km, kg);
                }
                break;
            }
            Console.WriteLine("Kargo ücretiniz: " + price + "Tl");
        }

        static double CargoPrice(double km, double kg)
        {
            return 100 + km + kg * 5;
        }
    }
}
