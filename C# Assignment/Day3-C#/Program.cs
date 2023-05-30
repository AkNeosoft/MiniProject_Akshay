using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections;

/// <summary>
/// Assignment - Array List
/// </summary>

class Program
{
    static void Main(string[] args)
    {
        ArrayList patientNames = new ArrayList();

        string name;
        string option;

        do
        {
            Console.WriteLine("Enter a patient name:");
            name = Console.ReadLine();
            patientNames.Add(name);

            Console.WriteLine("Do you want to add more names? (y/n)");
            option = Console.ReadLine();
        }
        while (option.ToLower() == "y");

        Console.WriteLine("Patient names in the list:");
        foreach (var patientName in patientNames)
        {
            Console.WriteLine(patientName);
        }

        Console.WriteLine("\nSelect one of the below options:");
        Console.WriteLine("1. Sort the list");
        Console.WriteLine("2. Reverse the list");
        Console.WriteLine("3. Remove a name");
        Console.WriteLine("4. Search for a name");
        Console.WriteLine("5. Exit");

        int Option;

        while (true)
        {
            Console.WriteLine("\nEnter your option (1-5):");
            if (int.TryParse(Console.ReadLine(), out Option))
            {
                if (Option == 1)
                {
                    patientNames.Sort();
                    foreach (var patientName in patientNames)
                    {
                        Console.WriteLine(patientName);
                    }

                }
                else if (Option == 2)
                {
                    patientNames.Reverse();
                    foreach (var patientName in patientNames)
                    {
                        Console.WriteLine(patientName);
                    }
                }
                else if (Option == 3)
                {
                    Console.WriteLine("Enter the name to remove:");
                    string nameToRemove = Console.ReadLine();
                    patientNames.Remove(nameToRemove);
                    Console.WriteLine("Name removed.");
                }
                else if (Option == 4)
                {
                    Console.WriteLine("Enter the name to search:");
                    string nameToSearch = Console.ReadLine();
                    bool found = patientNames.Contains(nameToSearch);
                    Console.WriteLine("Name found: " + found);
                }
                else if (Option == 5)
                {
                    Console.WriteLine("Exit");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }

}
