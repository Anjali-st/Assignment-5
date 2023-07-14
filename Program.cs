using System;

namespace ConsApp_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int numOfEmployees = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of working days for each employee: ");
            int numOfDays = int.Parse(Console.ReadLine());

            // Create the jagged array
            int[][] salaries = new int[numOfEmployees][];

            // Read salaries for each employee
            for (int i = 0; i < numOfEmployees; i++)
            {
                salaries[i] = new int[numOfDays];

                for (int j = 0; j < numOfDays; j++)
                {
                    Console.Write($"Enter the salary for Day {j + 1} of Employee {i + 1}: ");
                    salaries[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nEmployee Salaries:");

            // Display the salaries for each employee
            for (int i = 0; i < numOfEmployees; i++)
            {
                int totalSalary = 0;

                Console.Write($"Employee {i + 1}: ");

                for (int j = 0; j < numOfDays; j++)
                {
                    Console.Write($"{salaries[i][j]} ");
                    totalSalary += salaries[i][j];
                }

                Console.WriteLine($"Total Salary: {totalSalary}");
            }
            Console.ReadKey();
        }
    }
}
