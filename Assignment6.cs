using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    abstract class Arithmatic
    {
        public void add(int num1, int num2)
        {
            
            Console.WriteLine("The Addition of {0} and {1} is {2}", num1, num2, (num1 + num2));
        }

        abstract public  void multi(int num1, int num2);
        abstract public void divide(int num1, int num2);

    }
    

     class Excel : Arithmatic
    {
        public override void multi(int num1, int num2)
        {
            Console.WriteLine("The Multiplication of {0} and {1} is {2}", num1, num2, (num1 * num2));
        }

        public override void divide(int num1, int num2)
        {
            Console.WriteLine("The Division of {0} and {1} is {2}", num1, num2, (num1 / num2));
        }
    }

    class Rutik
    {
        public static void Main(String[] args)
        {

            Excel b = new Excel();
            b.add(12, 11);
            b.multi(43, 1);
            b.divide(30, 6);


        }
    }
}
