using System;
using System.Reflection.Metadata;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Derek version 0.1
    /// </author>
    public class DistanceConverter
    {
        private double metres;
        public void run()
        {
            Console.WriteLine("A. miles ");
            Console.WriteLine("B. metres ");
            Console.WriteLine("C. feets ");
            Console.WriteLine("Which unit would you intend to convert");
            string select = Console.ReadLine();

            if (select == "A")
            {
                Console.WriteLine("Type in the Number of miles");
                double mile = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Which unit would you intend to convert?");
                Console.WriteLine("1.Feet");
                Console.WriteLine("2.Metres");
                string Select = Console.ReadLine();

                if (Select == "1")
                {
                    double feet = mile * 5280;
                    Console.WriteLine(mile + " MILES contain " + feet + "FEETS");
                }
                else if (Select == "2") 
                {
                    double meter = mile * 1609.34;
                    Console.WriteLine(mile + "MILES contains " + meter + "METRES");
                }


                else if (Select == "B")
                {
                    Console.WriteLine("Type in the Number of metres");
                    double meter = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Which unit would you intend to convert?");
                }
                Console.WriteLine("1.Feet ");
                Console.WriteLine("2.Miles ");

                string SELECTB = Console.ReadLine();

                if (SELECTB  == "1")
                {
                    double feet = metres * 3.28;
                    Console.WriteLine(feet + "feets contains" + metres + "metres");
                }
                else if(SELECTB == "2")
                {
                    double Miles = metres * 0.000621;
                    Console.WriteLine(metres + " Metres contains " + Miles + "miles");
                }


                else if (Select == "C") 
                {
                    Console.WriteLine("Type in the Number of Feets");
                    double feet = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Which unit would you intend to convert?");
                    Console.WriteLine("1.Miles");
                    Console.WriteLine("2.Metres");

                    string SelectC = Console.ReadLine();

                    if (SelectC == "1")
                    {
                        double Miles = feet * 0.00019;
                        Console.WriteLine(feet + "FEETS CONTAINS" + Miles + "MILES");
                    }
                    else if (Select == "2")
                    {
                        double metres = feet * 0.3;
                        Console.WriteLine(feet + "FEETS CONTAINS" + metres + "METRES");
                    }
                }

               


            }
        }
    }
}
