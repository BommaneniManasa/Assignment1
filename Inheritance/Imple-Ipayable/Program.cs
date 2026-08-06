using System;
interface IPayable
{
    void CalculatePay();
}
class HourlyEmployee : IPayable
{
    public double HoursWorked = 8;
    public double PayPerHour = 500;
public void CalculatePay()
    {
        double pay = HoursWorked * PayPerHour;
        Console.WriteLine("Hourly Employee Pay : " + pay);
    }
}
class PermanentEmployee : IPayable
{
    public double Salary = 30000;
public void CalculatePay()
    {
        double hra = Salary * 0.15;
        double da = Salary * 0.10;
        double total = Salary + hra + da;
        double tax = total * 0.08;
        double net = total - tax;
Console.WriteLine("Permanent Employee Net Pay : " + net);
    }
}
class Program
{
    static void Main()
    {
        HourlyEmployee h = new HourlyEmployee();
        PermanentEmployee p = new PermanentEmployee();
  h.CalculatePay();
        p.CalculatePay();
    }
}
