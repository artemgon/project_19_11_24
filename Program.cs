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
                Magazine magazine = new Magazine();
                magazine.Title = "Magazine Title";
                magazine.Description = "Magazine Description";
                magazine.ContactPhone = "123456789";
                magazine.Email = "magazineemail.com";
                magazine.CreationYear = 2020;
                magazine.printInfo();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
