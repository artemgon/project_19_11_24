
namespace project_19_11_24.Classes
{
    public class Plane
    {
        public string Name;
        public string Manufacturer;
        public int Year;
        public string Type;
        public Plane()
        {
            Name = "empty";
            Manufacturer = "empty";
            Year = 0;
            Type = "empty";
        }
        public Plane(string name) : this()
        {
            Name = name;
        }
        public Plane(string name, string manufacturer) : this(name)
        {
            Manufacturer = manufacturer;
        }
        public Plane(string name, string manufacturer, int year) : this(name, manufacturer)
        {
            Year = year;
        }
        public Plane(string name, string manufacturer, int year, string type) : this(name, manufacturer, year)
        {
            Type = type;
        }
        public Plane(char[] name) : this()
        {
            Name = new string(name);
        }
        public Plane(char[] name, char[] manufacturer) : this(name)
        {
            Manufacturer = new string(manufacturer);
        }
        public Plane(char[] name, char[] manufacturer, double year) : this(name, manufacturer)
        {
            Year = (int)year;
        }
        public Plane(char[] name, char[] manufacturer, double year, char[] type) : this(name, manufacturer, year)
        {
            Type = new string(type);
        }
        // overloaded setters and getters
        public void SetName(string name)
        {
            Name = name;
        }
        public void SetName(char[] name)
        {
            Name = new string(name);
        }
        public void SetManufacturer(string manufacturer)
        {
            Manufacturer = manufacturer;
        }
        public void SetManufacturer(char[] manufacturer)
        {
            Manufacturer = new string(manufacturer);
        }
        public void SetYear(int year)
        {
            Year = year;
        }
        public void SetYear(double year)
        {
            Year = (int)year;
        }
        public void SetType(string type)
        {
            Type = type;
        }
        public void SetType(char[] type)
        {
            Type = new string(type);
        }
        public string GetName()
        {
            return Name;
        }
        public char[] GetNameCharArray()
        {
            return Name.ToCharArray();
        }
        public string GetManufacturer()
        {
            return Manufacturer;
        }
        public char[] GetManufacturerCharArray()
        {
            return Manufacturer.ToCharArray();
        }
        public int GetYear()
        {
            return Year;
        }
        public string GetType()
        {
            return Type;
        }
        public char[] GetTypeCharArray()
        {
            return Type.ToCharArray();
        }
        public void Print()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Manufacturer: {Manufacturer}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine();
        }
    }
}
