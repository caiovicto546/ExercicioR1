using System;
using ExercicioR1.Entities;

namespace ExercicioR1
{
    class Program
    {
        static void Main(string[] args)
        {
            string department;
            string nome;
            string level;
            double salary;
            int qtdContracts;
            

            Console.Write("Enter department's name:");
            department = Console.ReadLine();

            Console.WriteLine("Enter Worker data:");
            Console.Write("Name: ");
            nome = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            level = Console.ReadLine();
            Console.Write("Base Salary: R$");
            salary = double.Parse(Console.ReadLine());

            Console.Write("How many contracts to this worker?");
            qtdContracts = int.Parse(Console.ReadLine());

           for (int i = 0; i<qtdContracts; i++)
            {
                DateTime date;
                double vph;
                int duration;

                Console.WriteLine("Enter #" + i + 1 + " Contract data:");
                Console.Write("Data (DD/MM/YYYY): ");
                date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                vph = double.Parse(Console.ReadLine());
                Console.Write("Duration (Hours): ");
                duration = int.Parse(Console.ReadLine());

            }
            Console.ReadLine();
        }
    }
}
