using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    public string _firstName;
    public string _lastName;
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        _lastName = lastName;
    }
    public string FirstName { get => _firstName; set => _firstName = value; }
    public string LastName { get => _lastName; set => _lastName = value; }
    public void Print()
    {
        Console.WriteLine("Full name: " + _firstName + " " + _lastName);
    }
}
