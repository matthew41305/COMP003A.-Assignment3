namespace COMP003A._Assingment3
    /*
     * Author: Matthew Hudson
     * Course: COMP003A
     * Purpose: Conditional Statements
     */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numeric to letter Grade using an if-else statement");
            Console.Write("Enter a numeric grade (0-100):");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double numericGrade))
            {
                if (numericGrade >= 0 && numericGrade <= 100) ;
                {
                    if (numericGrade >= 90)
                    {
                        Console.WriteLine("Letter Grade: A");
                    }
                    else if (numericGrade >= 80)
                    {
                        Console.WriteLine("Letter Garde: B");
                    }
                    else if (numericGrade >= 70)
                    {
                        Console.WriteLine("Letter Grade: C");
                    }
                    else if (numericGrade >= 60)
                    {
                        Console.WriteLine("Letter Grade: D");
                    }
                    else
                    {
                        Console.WriteLine("Letter Grade: F"); // any number below 60
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid Input!"); //this is if they put in something like "k" or "a"
            }
            // New** Switch Section
            {
                Console.WriteLine("*************************************************************************************************");
                Console.Write("Enter Integer Day (1-7): ");

                string dayInput = Console.ReadLine();

                if (int.TryParse(dayInput, out int numericDay))
                {
                    switch (numericDay)
                    {
                        case 1:
                            Console.WriteLine("String Day: Moneday");
                            break;
                        case 2:
                            Console.WriteLine("String Day: Tuesday");
                            break;
                        case 3:
                            Console.WriteLine("String Day: Wednesday");
                            break;
                        case 4:
                            Console.WriteLine("String Day: Thursday");
                            break;
                        case 5:
                            Console.WriteLine("String Day: Friday");
                                ; break;
                        case 6:
                            Console.WriteLine("String Day: Saturday");
                            break;
                        case 7:
                            Console.WriteLine("String Day: Sunday");
                            break;
                        default:
                            Console.WriteLine("Invalid Day!");
                            break;


                    }
                }

            }

        }
    }
}
            
