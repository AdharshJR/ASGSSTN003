using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASGSSTN003
{
    class BOOK
    {
        private int bookno;
        private string booktitle;
        private float price;
        void TOTAL_COST(int N)
        {
            float tcost;
            tcost = price * N;
            Console.Write(tcost);


        }
        public void INPUT()
        {
            Console.Write("Enter Book Number : ");
            bookno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Book Title : ");
            booktitle = Console.ReadLine();
            Console.Write("Enter price per copy : ");
            price = Convert.ToInt32(Console.ReadLine());

        }

        public void PURCHASE()
        {
            int n;
            Console.Write("Enter number of copies to purchase : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Total cost : ");
            TOTAL_COST(n);
        }


        public static void Main(string[] args)
        {
            BOOK obj = new BOOK();
            obj.INPUT();
            obj.PURCHASE();
            Console.ReadKey();

        }
    }
}
