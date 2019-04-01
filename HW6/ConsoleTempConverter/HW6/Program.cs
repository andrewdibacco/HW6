using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    class Program
    {

        static void Main(string[] args)
        {
            float temp = 0;
            string input = "";
            string conversionType = "";

            do
            {
                Console.WriteLine("Please enter a temperature or 'Exit'.");
                input = Console.ReadLine();


                if (float.TryParse(input, out float inputNum))
                {
                    do
                    {
                        Console.WriteLine("Would you like to convert to 'C' or 'F'?");
                        conversionType = Console.ReadLine();

                        if (conversionType == "C")
                        {
                            temp = (inputNum - 32) * 5 / 9;
                        }
                        else if (conversionType == "F")
                        {
                            temp = inputNum * 9 / 5 + 32;
                        }
                        else if (conversionType == "Exit")
                        {
                            goto End;
                        }
                    }
                    while (conversionType != "C" && conversionType != "F");

                    Console.WriteLine(temp);

                }
            }
            while (input != "Exit");

        End:;
        }
    }
  
}
