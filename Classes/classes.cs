
namespace project_19_11_24.Classes
{
    public class Employee
    {
        public string SNP { get; set; }
        public string DateOfBirth { get; set; }
        public string PoneNumber { get; set; }
        public string WorkEmail { get; set; }
        public string Position { get; set; }
        public string Duties { get; set; }
        public Employee()
        {
            SNP = "Unknown";
            DateOfBirth = "Unknown";
            PoneNumber = "Unknown";
            WorkEmail = "Unknown";
            Position = "Unknown";
            Duties = "Unknown";
        }
        public Employee(string snp) : this()
        {
            SNP = snp;
        }
        public Employee(string snp, string dateOfBirth) : this(snp)
        {
            DateOfBirth = dateOfBirth;
        }
        public Employee(string snp, string dateOfBirth, string poneNumber) : this(snp, dateOfBirth)
        {
            PoneNumber = poneNumber;
        }
        public Employee(string snp, string dateOfBirth, string poneNumber, string workEmail) : this(snp, dateOfBirth, poneNumber)
        {
            WorkEmail = workEmail;
        }
        public Employee(string snp, string dateOfBirth, string poneNumber, string workEmail, string position) : this(snp, dateOfBirth, poneNumber, workEmail)
        {
            Position = position;
        }
        public Employee(string snp, string dateOfBirth, string poneNumber, string workEmail, string position, string duties) : this(snp, dateOfBirth, poneNumber, workEmail, position)
        {
            Duties = duties;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"SNP: {SNP}\nDate of birth: {DateOfBirth}\nPhone number: {PoneNumber}\nWork email: {WorkEmail}\nPosition: {Position}\nDuties: {Duties}");
        }
    }
}
