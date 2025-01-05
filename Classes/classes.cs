
using System.Runtime.InteropServices;

namespace project_19_11_24.Classes
{
    public class Matrix
    {
        public double[,] matrix;
        public int rows;
        public int columns;
        public Matrix()
        {
            matrix = new double[0, 0];
            rows = 0;
            columns = 0;
        }
        public Matrix(int rows) : this()
        { 
            this.rows = rows;
        }
        public Matrix(int rows, int columns) : this(rows)
        {
            this.columns = columns;
            matrix = new double[rows, columns];
        }
        public void SetMatrix(double[,] matrix)
        {
            this.matrix = matrix;
        }
        public double[,] GetMatrix()
        {
            return matrix;
        }
        public void SetRows(int rows)
        {
            this.rows = rows;
        }
        public int GetRows()
        {
            return rows;
        }
        public void SetColumns(int columns)
        {
            this.columns = columns;
        }
        public int GetColumns()
        {
            return columns;
        }
        public double MinimalElement()
        {
            double min = matrix[0, 0];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }
            }
            return min;
        }
        public double MaximalElement()
        {
            double max = matrix[0, 0];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
            }
            return max;
        }
        public void PrintMatrix()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
