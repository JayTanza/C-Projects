using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrudSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Crud();
        }

        static void Crud() {
            // Create an array to store Person objects
            Person[] people = new Person[100]; // Assuming a maximum of 100 people

            int option;
            int count = 0; // Keep track of the number of people in the array

            do
            {
                Console.WriteLine("CRUD Operations Menu:");
                Console.WriteLine("1. Create");
                Console.WriteLine("2. Retrieve");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1: // Create
                        if (count < people.Length)
                        {
                            Console.Write("Enter name: ");
                            string name = Console.ReadLine();
                            Console.Write("Enter age: ");
                            int age = int.Parse(Console.ReadLine());

                            Person newPerson = new Person(name, age);
                            people[count] = newPerson;
                            count++;

                            Console.WriteLine("Person created successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Array is full. Cannot add more people.");
                        }
                        break;

                    case 2: // Retrieve
                        Console.WriteLine("List of People:");
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine($"ID: {i}, Name: {people[i].Name}, Age: {people[i].Age}");
                        }
                        break;

                    case 3: // Update
                        Console.Write("Enter the ID of the person to update: ");
                        int updateId = int.Parse(Console.ReadLine());

                        if (updateId >= 0 && updateId < count)
                        {
                            Console.Write("Enter new name: ");
                            string newName = Console.ReadLine();
                            Console.Write("Enter new age: ");
                            int newAge = int.Parse(Console.ReadLine());

                            people[updateId].Name = newName;
                            people[updateId].Age = newAge;

                            Console.WriteLine("Person updated successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid ID. Person not found.");
                        }
                        break;

                    case 4: // Delete
                        Console.Write("Enter the ID of the person to delete: ");
                        int deleteId = int.Parse(Console.ReadLine());

                        if (deleteId >= 0 && deleteId < count)
                        {
                            for (int i = deleteId; i < count - 1; i++)
                            {
                                people[i] = people[i + 1];
                            }
                            count--;

                            Console.WriteLine("Person deleted successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid ID. Person not found.");
                        }
                        break;

                    case 5: // Exit
                        Console.WriteLine("Exiting the program.");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

            } while (option != 5);
        }
    }
}
