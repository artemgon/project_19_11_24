
namespace project_19_11_24.Classes
{
    public class Magazine
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ContactPhone { get; set; }
        public string Email { get; set; }
        public int CreationYear { get; set; }
        public void printInfo()
        {
            Console.WriteLine("Magazine Info:");
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("Contact Phone: " + ContactPhone);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Creation Year: " + CreationYear);
        }
    }
}
