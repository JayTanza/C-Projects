using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Modifiers_2
{
    internal class User
    {
        private string firstName;
        private string lastName;
        private int age;

        //// Getter and Setter for FirstName
        //public string FirstName
        //{ 
        //    get { return firstName;} 
        //    set { firstName = value; }
        //}
        //// Getter and Setter for LastName
        //public string LastName 
        //{
        //    get { return lastName;}
        //    set { lastName = value; }
        //}
        //// Getter and Setter for Age
        //public int Age 
        //{
        //    get { return age; }
        //    set 
        //    {
        //        if (value >= 0)
        //        {
        //            age = value;
        //        }else{
        //            Console.WriteLine("Age cannot be less than Zero.");
        //        }
        //    }
        //}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        // Constructor to initialize user details
        public User(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;

            // Ensure age is non-negative
            if (age >= 0)
            {
                Age = age;
            }
            else
            {
                Console.WriteLine("Age cannot be negative.");
                Age = 0; // Default age to 0 if it's negative
            }
        }
        public void DisplayUserDetails()
        {
            Console.WriteLine($"User: {FirstName} {LastName}");
            Console.WriteLine($"Age: {Age} years");
        }
    }
}
