using System;
using System.Globalization;
using ExercicioR1.Entities;
using ExercicioR1.Entities.Enums;

namespace ExercicioR1
{
    class Program
    {
        static void Main(string[] args)
        {
            Department dept;
            Worker worker;
            WorkerLevel level;
            string department;
            string nome;
            string monthAndYear;            
            double salary;
            int qtdContracts;
            int month;
            int year;
            

            Console.Write("Enter department's name:");
            department = Console.ReadLine();
            dept = new Department(department);

            Console.WriteLine("Enter Worker data:");
            Console.Write("Name: ");
            nome = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: R$");
            salary = double.Parse(Console.ReadLine());
            worker = new Worker(nome, level, salary, dept);

            Console.Write("How many contracts to this worker?");
            qtdContracts = int.Parse(Console.ReadLine());

           for (int i = 0; i<qtdContracts; i++)
            {
                DateTime date;
                HourContract contract;
                double vph;
                int duration;

                Console.WriteLine("Enter #" + (i + 1) + " Contract data:");
                Console.Write("Data (DD/MM/YYYY): ");
                date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                vph = double.Parse(Console.ReadLine());
                Console.Write("Duration (Hours): ");
                duration = int.Parse(Console.ReadLine());

                contract = new HourContract(date, vph, duration);
                worker.AddContract(contract);

                Console.WriteLine();

            }
            Console.WriteLine();

            Console.WriteLine("Enter mounth and year to calculate income (MM/YYYY): ");
            monthAndYear = Console.ReadLine();

            month = int.Parse(monthAndYear.Substring(0, 2));
            year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": R$" + worker.Income(year,month),"F2",CultureInfo.InvariantCulture);

            Console.ReadLine();
        }
    }
}
