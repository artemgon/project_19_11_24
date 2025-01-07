
namespace project_19_11_24.Classes
{
    public class Shop
    {
        public string Title { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public void printInfo()
        {
            Console.WriteLine("Shop Info:");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Phone: {Phone}");
            Console.WriteLine($"Email: {Email}");
        }
    }
}
