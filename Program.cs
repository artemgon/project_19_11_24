using project_19_11_24.Classes;

int number = int.Parse(Console.ReadLine() ?? "");

bool palindrome(int number)
{
    int temp = number;
    int reverse = 0;
    while (temp != 0)
    {
        int remainder = temp % 10;
        reverse = reverse * 10 + remainder;
        temp /= 10;
    }
    return reverse == number;
}

try
{ 
    if (palindrome(number))
    {
        Console.WriteLine("Number is a palindrome.");
    }
    else
    {
        throw new Exception();
    }
}
catch (Exception e)
{
    Console.WriteLine("Error... Something went wrong.");  
}