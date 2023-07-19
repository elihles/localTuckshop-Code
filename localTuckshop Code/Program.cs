using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace localTuckshop_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char StudentCard;
            double items, itemPrice, total, Discount, due, DiscountAmount;
            total = 0;
            Discount = 0.1;
            DiscountAmount = 0;
            due = 0;
            Console.Write("Student Card:Y/N:");
            StudentCard = char.ToUpper(Console.ReadLine()[0]);
            Console.Write("How many items ?");
            items=double.Parse(Console.ReadLine());
            for(int i = 1; i <= items; i++) 
            {
                Console.Write("Enter the item Price :",i);
                itemPrice=double.Parse(Console.ReadLine());
                total += itemPrice;
            }
            DiscountAmount = total * Discount;
            due = total - DiscountAmount;
            Console.WriteLine();
            Console.WriteLine("Total     : {0:C2}", total);
            Console.WriteLine("Discount  : {0:C2}", DiscountAmount);
            Console.WriteLine("Due       : {0:C2}", due);
            Console.ReadLine();


           




        }
    }
}
