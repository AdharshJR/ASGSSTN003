using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASGSSTN003
{
    class Students
    {
        int rno=0;
        string name;
        double[] mark = new double[3];
        double tot=0;
        
        public void read()
        {
            Console.Write("Enter Roll Number : ");
            rno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            Console.Write("Enter Name : ");
            name = Console.ReadLine();
            Console.WriteLine(" ");
            Console.Write("Enter the Marks : ");
            for(int i = 0; i < 3; i++)
            {
                mark[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void calculate()
        {
            for (int i = 0; i < 3; i++)
            {
                tot = tot + mark[i];
            }
        }
        public void display()
        {
            Console.WriteLine("Roll No. : "+rno);
            Console.WriteLine("Name : "+name);
            Console.Write("Marks : ");
            for(int i = 0; i < 3; i++)
                Console.WriteLine(mark[i]);
            Console.WriteLine("Total : "+tot);
        }
        public static void Main(string[] args)
        {
            Students stud = new Students();
            stud.read();
            stud.calculate();
            stud.display();
            Console.ReadKey();
        }
    }
}
