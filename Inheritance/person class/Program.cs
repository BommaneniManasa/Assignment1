using System;
class Person
{
    private string firstName;
    private string lastName;
    private string emailAddress;
    private DateTime dateOfBirth;
    public Person(string fName, string lName, string email, DateTime dob)
    {
        firstName = fName;
        lastName = lName;
        emailAddress = email;
        dateOfBirth = dob;
    }
    public bool IsAdult
    {
        get
        {
            return (DateTime.Now.Year - dateOfBirth.Year) >= 18;
        }
    }
    public string SunSign
    {
        get
        {
            return "Unknown";
        }
    }
    public bool IsBirthDay
    {
        get
        {
            return DateTime.Now.Month == dateOfBirth.Month &&
                   DateTime.Now.Day == dateOfBirth.Day;
        }
    }
    public string ScreenName
    {
        get
        {
            return firstName.ToLower() + dateOfBirth.Day + dateOfBirth.Month;
        }
    }

    // Display Method
    public void Display()
    {
        Console.WriteLine("First Name : " + firstName);
        Console.WriteLine("Last Name : " + lastName);
        Console.WriteLine("Email : " + emailAddress);
        Console.WriteLine("Date of Birth : " + dateOfBirth.ToShortDateString());
        Console.WriteLine("Is Adult : " + IsAdult);
        Console.WriteLine("Sun Sign : " + SunSign);
        Console.WriteLine("Is Birthday : " + IsBirthDay);
        Console.WriteLine("Screen Name : " + ScreenName);
    }
}
// Derived Class
class Employee : Person
{
    public double Salary;
public Employee(string fName, string lName, string email, DateTime dob, double salary)
        : base(fName, lName, email, dob)
    {
        Salary = salary;
    }
 public void DisplayEmployee()
    {
        Display();
        Console.WriteLine("Salary : " + Salary);
    }
}
class Program
{
    static void Main()
    {
        Employee emp = new Employee(
            "Manasa",
            "Bommaneni",
            "manasa@gmail.com",
            new DateTime(2004, 7, 10),
            50000);

        emp.DisplayEmployee();
    }
}
