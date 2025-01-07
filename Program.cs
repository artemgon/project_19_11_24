using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace project_19_11_24
{
    public class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            List<int> list = new List<int>();
            List<int> data = new List<int>();
            Console.WriteLine("Enter 10 numbers for list: ");
            for (int i = 0; i < 10; i++)
            {
                list.Add(int.Parse(Console.ReadLine() ?? ""));
            }
            Console.WriteLine("Enter numbers for filter: ");
            while (true)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }
                data.Add(int.Parse(input));
            }

            try
            {
                Filter(list, data);
                Console.WriteLine("Filtered list: ");
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void Filter(List<int> list, List<int> data)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < data.Count; j++)
                {
                    if (list[i] == data[j])
                    {
                        list.RemoveAt(i);
                        i--;
                        break;
                    }
                }
            }
        }
    }
}
