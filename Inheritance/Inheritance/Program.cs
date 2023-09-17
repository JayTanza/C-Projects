using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Jay","Tanza",22);
            p.introduceSelf();
            
            Toddler t = new Toddler("Test1","Test",1,"RPG");
            t.introduceSelf();
            t.Crying();
        }
    }

    class Person {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int age1 { get; set; }

        public Person(string fname, string lname, int age)
        {
            firstname = fname;
            lastname = lname;
            age1 = age;
        }

        public void introduceSelf(){ 
            Console.WriteLine(firstname + " " + lastname +" " +age1);
        }
    }

    class Toddler : Person
    {
        public string faveGame { get; set; }
        public Toddler(string fname, string lname, int age, string faveGame) : base(fname, lname, age) {
            this.faveGame = faveGame;
        }

        public void Crying()
        {
            Console.WriteLine(firstname + " is Crying.");
        }

        public void introduceSelf() {
            base.introduceSelf();
            Console.WriteLine("Favorite Game : "+faveGame);
        }
    }
}
