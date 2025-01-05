
namespace project_19_11_24.Classes
{
    internal class City
    {
        public string cityName { get; set; }
        public string countryName { get; set; }
        public string phoneCode { get; set; }
        public List<string> cityDistricts { get; set; }
        public int Population { get; set; }
        public City()
        {
            cityName = "Unknown";
            countryName = "Unknown";
            phoneCode = "Unknown";
            cityDistricts = new List<string>();
            Population = 0;
        }
        public City(string name) : this()
        {
            cityName = name;
        }
        public City(string name, string country) : this(name)
        {
            countryName = country;
        }
        public City(string name, string country, string code) : this(name, country)
        {
            phoneCode = code;
        }
        public City(string name, string country, string code, List<string> districts) : this(name, country, code)
        {
            cityDistricts = districts;
        }
        public City(string name, string country, string code, List<string> districts, int population) : this(name, country, code, districts)
        {
            Population = population;
        }
        public void printInfo()
        {
            Console.WriteLine("City Name: " + cityName);
            Console.WriteLine("Country Name: " + countryName);
            Console.WriteLine("Phone Code: " + phoneCode);
            Console.WriteLine("City Districts: ");
            foreach (string district in cityDistricts)
            {
                Console.WriteLine(district);
            }
            Console.WriteLine("Population: " + Population);
        }
    }
}
