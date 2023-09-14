using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string FullUpperName
    {
        get { return $"{FirstName} {LastName}".ToUpper(); }
    }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person("Shivam", "Saini");

        string fullNameUpper = person.FullUpperName;
        Console.WriteLine("Full Name (Uppercase): " + fullNameUpper);

        Console.ReadLine();
    }
}
