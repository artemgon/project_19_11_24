
namespace project_19_11_24.Classes
{
    public class Website
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string IP_Address { get; set; }
        public void printInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Url: " + Url);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("IP Address: " + IP_Address);
        }
    }
}
