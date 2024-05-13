using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{

    interface Salary
    {
        float calchra(float basic);

        float calda(float basic);
    }

    public class trainersal : Salary
    {
        public float calchra(float basic)
        {

            return basic * 0.1f;

        }
        public float calda(float basic)
        {
            return basic * 0.05f;
        }
    }

    public class ProjectManager : Salary
    {
        public float calchra(float basic)
        {
            return basic * 0.2f;

        }

        public float calda(float basic)
        {
            return basic * 0.1f;
        }

    }

    public class useinterface
    {
        public static void Main(string[] args)
        {

            trainersal obj1 = new trainersal();
            ProjectManager obj2 = new ProjectManager();

            float trainerhra = obj1.calchra(12000);
            float trainerda = obj1.calda(12000);

            float PMhra = obj2.calchra(30000);
            float PMda = obj2.calda(30000);

            Console.WriteLine("Hra from Training Salary :" + trainerhra);
            Console.WriteLine("Da from Training Salary :" + trainerda);

            Console.WriteLine("*******************************");

            Console.WriteLine("Hra from Project Manager Salary : " + PMhra);
            Console.WriteLine("Da from Project Manager Salary : " + PMda);

        }
    }
}
