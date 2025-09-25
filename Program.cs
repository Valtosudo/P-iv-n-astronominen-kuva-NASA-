using System.Net.Http.Headers;
using System.Globalization;


namespace P_iv_n_astronominen_kuva_NASA_;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Minkä ajan kuvan haluat ladata ?");
        while (true)
        {
            Console.WriteLine("Anna päivämäärä muodossa yyyy-MM-dd (esim. 2025-09-25)");
            string? input = Console.ReadLine();

            if (DateTime.TryParseExact(input, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime päivämäärä))
            {
                Console.WriteLine($"Annoit päivämäärän: {päivämäärä:yyyy.mm.dd}");
                break; // poistutaan loopista kun saatiin kelvollinen arvo
            }
            else
            {
                Console.WriteLine("Virheellinen syöte! Kokeile uudestaan.");
            }
        }
    }
}
