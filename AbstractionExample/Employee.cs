using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Employee : Person
{
    private string _department;
    public Employee(string firstName, string lastName, string Dept) : base(firstName, lastName)
    {
        _department = Dept;
    }

    public string Department { get => _department; set => _department = value; }
    public void Print()
    {
        Console.WriteLine("Department: " + _department + ", ");
        base.Print();
    }
}

