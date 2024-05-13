using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    delegate int mydel();
    delegate int yourdel(int a);

    internal class DelegateAssignment
    {
        static int greet()
        {
            Console.WriteLine("Namaste");
            return 0;
        }

        static int marrychristmas()
        {
            Console.WriteLine("Wish you mary christms to you");
            return 0;

        }

        static int odd(int a)
        {
            Console.WriteLine("This is odd Number");
            return 0;
        }

        static int even(int a)
        {
            Console.WriteLine("This is Even number ");
            return 0;
        }


        public static void Main(String[] args)
        {
            mydel obj1;
            Console.WriteLine("What kind of gesture you want");
            string choice = Console.ReadLine();
            choice = choice.ToLower();
            if (choice == "greet")
            {
                obj1 = new mydel(greet);
            }
            else
            {
                obj1 = new mydel(marrychristmas);
            }
            obj1();


            yourdel obj2;
            Console.WriteLine("Enter your Number");
            int ans = Convert.ToInt32(Console.ReadLine());
            ans = ans % 2;

            if (ans == 0)
            {
                obj2 = new yourdel(even);
            }
            else
            {
                obj2 = new yourdel(odd);
            }
            obj2(ans);
        }
    }
}
