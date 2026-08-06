using System;
interface IPayable
{
    void CalculatePay();
}
class Person
{
    public string Name;

    public Person(string name)
    {
        Name = name;
    }
}
class HourlyEmployee : Person, IPayable
{
    public double HoursWorked;
    public double PayPerHour;
 public HourlyEmployee(string name, double hoursWorked, double payPerHour)
        : base(name)
    {
        HoursWorked = hoursWorked;
        PayPerHour = payPerHour;
    }
public void CalculatePay()
    {
        double TotalPay = HoursWorked * PayPerHour;
Console.WriteLine("Hourly Employee");
        Console.WriteLine("Name : " + Name);
        Console.WriteLine("Hours Worked : " + HoursWorked);
        Console.WriteLine("Pay Per Hour : " + PayPerHour);
        Console.WriteLine("Total Pay : " + TotalPay);
    }
}

class PermanentEmployee : Person, IPayable
{
    public double BasicSalary;
    public double HRA;
    public double DA;
    public double Tax;
    public double NetPay;
    public double TotalPay;
public PermanentEmployee(string name, double basicSalary)
        : base(name)
    {
        BasicSalary = basicSalary;
    }
 public void CalculatePay()
    {
        HRA = BasicSalary * 0.15;
        DA = BasicSalary * 0.10;
        TotalPay = BasicSalary + HRA + DA;
        Tax = TotalPay * 0.08;
        NetPay = TotalPay - Tax;
Console.WriteLine("\nPermanent Employee");
        Console.WriteLine("Name : " + Name);
        Console.WriteLine("Basic Salary : " + BasicSalary);
        Console.WriteLine("HRA : " + HRA);
        Console.WriteLine("DA : " + DA);
        Console.WriteLine("Total Pay : " + TotalPay);
        Console.WriteLine("Tax : " + Tax);
        Console.WriteLine("Net Pay : " + NetPay);
    }
}
class Program
{
    static void Main(string[] args)
    {
        HourlyEmployee h = new HourlyEmployee("Manasa", 8, 500);
        h.CalculatePay();
 PermanentEmployee p = new PermanentEmployee("Ravi", 30000);
        p.CalculatePay();
Console.ReadKey();
    }
}
