using System;
interface IPayable
{
    void CalculatePay();
}

class Program
{
    static void Main()
    {
        Console.WriteLine("CalculatePay() method declared in IPayable interface.");
    }
}
