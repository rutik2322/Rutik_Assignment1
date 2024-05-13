using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Array
    {
        public static void Main(String[] args)
        {
            add(12, 87);
            System.Console.WriteLine("*****************");

            add(23, 43, 78);
            System.Console.WriteLine("******************");
            pricelist("Parle", "Hide and seek", "Cream Biscuit", "Glucose");

        }

        static void add(params int[] a)
        {
            foreach (int x in a)
            {
                Console.WriteLine(x);
            }
        }

        static void pricelist(string Companyname, params string[] product)
        {
            Console.WriteLine("{0} company have folowing product", Companyname);
            for (int i = 0; i < product.Length; i++)
            {
                Console.WriteLine(product[i]);
            }
        }
    }
}
