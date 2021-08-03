using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Customer : Person
{
    private string _deliveryAddress;
    public Customer(string firstname, string lastName, string DAddress) : base (firstname, lastName)
    {
        _deliveryAddress = DAddress;

    }
    public string DeliveryAddress { get => _deliveryAddress; set => _deliveryAddress = value; }
    public void Print()
    {
        Console.WriteLine("Delivery Address: " + _deliveryAddress + " ");
        base.Print();
    }
}
