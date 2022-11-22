using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ASGSSTN003
{
    public class Student
    {
        public int roll_number;
        public String name;
        public void insert(int i, String n)
        {
            roll_number = i;
            name = n;
        }
        public void displaydetails()
        {
            Console.WriteLine("Roll Number : "+roll_number );
            Console.WriteLine("Name : " + name);
        }
    }
    class StudentDetails
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student();
            s1.insert(101, "Adharsh");
            s2.insert(102, "Ganesh");
            Console.WriteLine("Student 1" );
            s1.displaydetails();
            Console.WriteLine("");
            Console.WriteLine("Student 2");
            s2.displaydetails();
            Console.ReadKey();
        }
    }
}
