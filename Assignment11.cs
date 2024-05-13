using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Assignment2
    {
        public static void Main(string[] args)
        {


            Console.WriteLine("Enter Number 1 :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2 :");
            int b = Convert.ToInt32(Console.ReadLine());




            try
            {
                int ans = a / b;
                Console.WriteLine("The Answer is : " + ans);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Enter Numeric number only " + ex.Message);


            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("We can not divide by 0 " + ex.Message);
            }
        }
    }
}
