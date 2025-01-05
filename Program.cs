using project_19_11_24.Classes;

namespace project_19_11_24
{
    public class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            try
            {
                City city1 = new City();
                city1.printInfo();
                city1.printInfo();
                Console.WriteLine();
                City city2 = new City("Istanbul");
                Console.WriteLine(city2.cityName);
                Console.WriteLine();
                City city3 = new City("Istanbul", "Turkey");
                Console.WriteLine(city3.cityName + " " + city3.countryName);
                Console.WriteLine();
                City city4 = new City("Istanbul", "Turkey", "+90");
                Console.WriteLine(city4.cityName + " " + city4.countryName + " " + city4.phoneCode);
                Console.WriteLine();
                City city5 = new City("Istanbul", "Turkey", "+90", new List<string> { "Kadikoy", "Besiktas", "Beyoglu" });
                Console.WriteLine(city5.cityName + " " + city5.countryName + " " + city5.phoneCode);
                Console.WriteLine();
                City city6 = new City("Istanbul", "Turkey", "+90", new List<string> { "Kadikoy", "Besiktas", "Beyoglu" }, 15000000);
                Console.WriteLine(city6.cityName + " " + city6.countryName + " " + city6.phoneCode + " " + city6.Population);
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}