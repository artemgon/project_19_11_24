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
                Plane plane = new Plane("Boeing 747", "Boeing", 1969, "Passenger");
                Console.WriteLine($"Name: {plane.Name}");
                Console.WriteLine($"Manufacturer: {plane.Manufacturer}");
                Console.WriteLine($"Year: {plane.Year}");
                Console.WriteLine($"Type: {plane.Type}");
                Console.WriteLine();
                Plane plane1 = new Plane("F-22 Raptor", "Lockheed Martin", 1997, "Military jet");
                plane1.Print();
                Console.WriteLine();
            }
            catch (Exception e)
            {
            }
        }
    }
}
