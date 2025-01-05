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
                Employee employee = new Employee();
                employee.ShowInfo();
                Console.WriteLine();
                Employee employee1 = new Employee(snp: "John Doe", dateOfBirth: "01.01.2000", poneNumber: "+1234567890", workEmail: "johndoe123@gmail.com", position: "Developer", duties: "Write code");
                employee1.ShowInfo();
                Console.WriteLine();
                Console.WriteLine(employee1.Duties);
                Console.WriteLine();
                employee1.Duties = "1. Write code\n2. Test code\n3. Fix bugs";
                Console.WriteLine(employee1.Duties);
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}