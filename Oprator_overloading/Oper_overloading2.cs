using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oprator_overloading
{
    class Circle

    {

        int radius;
        static public bool operator ==(Circle c1, Circle c2)
        {
            if (c1.radius == c2.radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static public bool operator !=(Circle c1, Circle c2)
        {
            if (c1.radius != c2.radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Circle()
            {
        }

        public  Circle(int rad)
        {
            radius = rad;
        }
        static public Circle operator ++(Circle c1)
        {
            Console.WriteLine("++ operator executed!!!!");
            c1.radius++;
            return c1;
        }
        public void Area()
        {
           int area = radius * radius;
            Console.WriteLine("Area of circle is="+area);
        }
        
    }

    internal class Oper_overloading2
    {
    }
}
