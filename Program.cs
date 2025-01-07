using project_19_11_24.Classes;

namespace project_19_11_24
{
    public class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Website Information:");
            Console.WriteLine();
            try
            {
                Website website = new Website();
                website.Name = "Google";
                website.Url = "https://www.google.com";
                website.Description = "Search Engine";
                website.IP_Address = "123.456.789.0";
                website.printInfo();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
