using System;
using System.Globalization;
using EnumLearning.Entities;
using EnumLearning.Entities.Enums;

namespace EnumLearning {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter Department's name: ");
            string deptName = Console.ReadLine();
            Console.Write("Enter Worker Data: ");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior)");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many conracts to this worker? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) {

                Console.WriteLine($"Enter #{i} Contract Data:");
                Console.WriteLine("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (Hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }
            Console.WriteLine();
            Console.Write("Enter mouth and year to calculate income(MM/YYYY): ");
            string mountAndYear = Console.ReadLine();
            int mount = int.Parse(mountAndYear.Substring(0, 2));
            int year = int.Parse(mountAndYear.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department " + worker.Department.Name);
            Console.WriteLine("Income for " + mountAndYear + ": " + worker.Income(year, mount));

        }
    }
}