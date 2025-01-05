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
                Matrix matrix = new Matrix(3, 3);
                matrix.SetMatrix(new double[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } });
                Console.WriteLine(matrix.MinimalElement());
                Console.WriteLine();
                matrix.PrintMatrix();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
