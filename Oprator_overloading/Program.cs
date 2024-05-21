

using Oprator_overloading;

internal class Program
{
    private static void Main(string[] args)
    {
        Employee e1= new Employee(1,"avi",10000,"computer");
        Employee e2 = new Employee(2, "sarthak", 26000, "it");
        e1.showEmployee();
        e2.showEmployee();
        if (e1 == e2)
        {
            Console.WriteLine("Both having same sal");
        }
        else
        {
            Console.WriteLine("different sal...");
        }
        if(e1)
        {
            Console.WriteLine("salary is greater than 25000");
        }
        else {
            Console.WriteLine("salary is less than 25000");
        }
        if (e2)
        {
            Console.WriteLine("salary is greater than 25000");
        }
        else
        {
            Console.WriteLine("salary is less than 25000");
        }

        Employee e3 = e1 + e2;
        Console.WriteLine(e3);


    }
}