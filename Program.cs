using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Subcontractor> subcontractors = new List<Subcontractor>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- Subcontractor Entry Menu ---");
            Console.WriteLine("1. Add Subcontractor");
            Console.WriteLine("2. List Subcontractors");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    subcontractors.Add(CreateSubcontractor());
                    break;

                case "2":
                    DisplaySubcontractors(subcontractors);
                    break;

                case "3":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid selection. Try again.");
                    break;
            }
        }
    }

    static Subcontractor CreateSubcontractor()
    {
        Console.Write("Enter contractor name: ");
        string name = Console.ReadLine();

        Console.Write("Enter contractor number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter start date (yyyy-mm-dd): ");
        DateTime startDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter shift (1 = Day, 2 = Night): ");
        int shift = int.Parse(Console.ReadLine());

        Console.Write("Enter hourly pay rate: ");
        double rate = double.Parse(Console.ReadLine());

        Console.Write("Enter hours worked: ");
        float hours = float.Parse(Console.ReadLine());

        Subcontractor sc = new Subcontractor(name, number, startDate, shift, rate);
        float pay = sc.ComputePay(hours);

        Console.WriteLine($"Computed Pay: ${pay:F2}");

        return sc;
    }

    static void DisplaySubcontractors(List<Subcontractor> subs)
    {
        Console.WriteLine("\n--- Subcontractor List ---");

        foreach (var sc in subs)
        {
            Console.WriteLine($"Name: {sc.ContractorName}, " +
                              $"Number: {sc.ContractorNumber}, " +
                              $"Start Date: {sc.ContractorStartDate.ToShortDateString()}, " +
                              $"Shift: {sc.Shift}, " +
                              $"Hourly Rate: {sc.HourlyPayRate}");
        }
    }
}
