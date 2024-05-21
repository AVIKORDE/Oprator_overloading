using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Oprator_overloading
{
    
    class Employee
    {

        int id;
        string name;
        int sal;
        string dep;
        public int getid()
        { return id; }
        public void setid(int id)
        { this.id = id; }

        static public Employee operator +(Employee emp1, Employee emp2)
        {
            Employee employee = new Employee(); 
            employee.sal = emp1.sal+emp2.sal;
            return employee;
        }

        static public bool operator true(Employee emp)
        {
            if (emp.sal<25000)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static public bool operator false(Employee emp)
        {
            if (emp.sal<250000)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static public bool operator == (Employee emp1, Employee emp2)
        {
            if (emp1.sal == emp2.sal)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static public bool operator !=(Employee emp1, Employee emp2)
        {
            if (emp1.sal != emp2.sal)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Employee()
        {

        }
        public Employee(int i, string nm, int sa,string dept)
        {
            id = i;
            name = nm;
            sal = sa;
            dep = dept;
        }
        public void showEmployee()
        {
            Console.WriteLine(" id= " + id + " Name=" + name + " salary=" + sal+"department ="+dep);
        }
       

    }
    internal class Oprators_overload
    {
    }
}
