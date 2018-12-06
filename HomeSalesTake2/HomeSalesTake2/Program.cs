using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HomeSalesTake2
{
    class Program
    {
        static void Main(string[] args)
        {
            string salesPerson = "a";
            string sale;
            double convertedSale;
            double totalSalesPerson1 = 0;
            double totalSalesPerson2 = 0;
            double totalSalesPerson3 = 0;
            double grandTotal = 0;

            while (salesPerson != "Z" && salesPerson != "z") 
            {

                Write("Please enter a D, E, or F for your specified salesperson >>>> ");
                salesPerson = ReadLine();
                WriteLine("Enter the value of the sale >>>> ");
                sale = ReadLine();
                convertedSale = Convert.ToDouble(sale);


                if (salesPerson == "D" || salesPerson == "d")
                {
                    totalSalesPerson1 = totalSalesPerson1 + convertedSale;
                   
                }
                else if (salesPerson == "E" || salesPerson == "e")
                {
                    totalSalesPerson2 = totalSalesPerson2 + convertedSale;
                    
                }
                else if (salesPerson == "F" || salesPerson == "f")
                {
                    totalSalesPerson3 = totalSalesPerson3 + convertedSale;
                   
                }
                else
                {
                    WriteLine("Invalid entry, try again");
                }
                grandTotal = grandTotal = totalSalesPerson1 + totalSalesPerson2 + totalSalesPerson3;
             } 

            WriteLine("The grand total between all 3 salepersons was: {0}", grandTotal.ToString("C"));
            if (totalSalesPerson1 > totalSalesPerson2 && totalSalesPerson1 > totalSalesPerson3)
            {
                WriteLine("Danielle had the highest sold at: {0}", totalSalesPerson1.ToString("C"));
            }
            else if (totalSalesPerson2 > totalSalesPerson1 && totalSalesPerson2 > totalSalesPerson3)
            {
                WriteLine("Edward had the highest sold at: {0}", totalSalesPerson2.ToString("C"));
            }
            else if (totalSalesPerson3 > totalSalesPerson2 && totalSalesPerson3 > totalSalesPerson1)
            {
                WriteLine("Francis had the highest sold at: {0}", totalSalesPerson3.ToString("C"));
            }
            else
            {
                WriteLine("There was no winner, because there was a tie");
            }


        }
    }
}
