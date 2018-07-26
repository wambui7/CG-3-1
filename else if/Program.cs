using System;

namespace else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("the program is looking for date and month");
            string monthinput = Console.ReadLine();
            string monthoutput = "";

            if (monthinput == "1")
            {
                monthoutput = "January";
            }
            else if (monthinput == "2")
            {

                monthoutput = "February";
            }

            else if (monthinput == "3")
            {
                monthoutput = "March";

            }
            else if (monthinput == "4")
            {

                monthoutput = "April";

            }
            else if (monthinput == "5")
            {
                monthoutput = "May";

            }
            else if (monthinput == "6")
            {

                monthoutput = "June";
            }
            else if (monthinput == "7")
            {
                monthoutput = " July";
            }
            else
            {
                monthinput = "if the month is unknown";


            }
            Console.WriteLine(" put a number that corresponds with {0}.", "monthoutput");
            Console.ReadLine();
        }

    }
}
   
 
