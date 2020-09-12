using System;
using System.Collections.Generic;
using System.Globalization;
using composition.Entities;
using composition.Entities.Enums;

namespace composition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the departaments name: ");
            string depName = Console.ReadLine();
            System.Console.WriteLine("Enter the work data: ");
            System.Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Level (Junior/MidLevel/Senior)");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            System.Console.WriteLine("Base salary: ");
            double baseSlary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Departament dept = new Departament(depName);
            Worker worker = new Worker(name, level, baseSlary, dept);


            System.Console.WriteLine("How many constacts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                System.Console.WriteLine($"Enter #{i} contract data: ");
                System.Console.WriteLine("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                System.Console.WriteLine("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                System.Console.WriteLine("Duration (hour): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);

            }

            System.Console.WriteLine(); 
            System.Console.WriteLine("Ente month and year to calculate income(MM/yyyy): ");
            string monthYear = Console.ReadLine();
            int month = int.Parse(monthYear.Substring(0, 2));
            int year = int.Parse(monthYear.Substring(3));

            System.Console.WriteLine("Name: " + worker.Name);
            System.Console.WriteLine("Departament: " + worker.Departament.Name);
            System.Console.WriteLine("Income for: " + monthYear + ": " + worker.Income(year, month));


        }
    }
}
