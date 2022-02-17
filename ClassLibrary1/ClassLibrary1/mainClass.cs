

namespace ClassLibrary1
{
    class Controller
    {
        public static void Main(string[] args)
        {

            Console.Write("-------  MENUE  ------ ");
            Console.Write("\n1. REVERSE NUMBER  ----");
            Console.Write("\n2. BIGEST DIGIT  ----");
            Console.Write("\n3. FIRST NUMBER IN STRING   ----");
            Console.Write("\n4. MAXIMUM INPUT NUMBER  ----");
            Console.Write("\n5. EXIT  ----");

            int choice;
            do
            {
                bool result = int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {

                    case 1:
                        {
                            int n;
                            Console.Write("Enter integer number ----> ");

                            n = int.Parse(Console.ReadLine());

                            Console.Write("Reverse of " + n + " is " + Operations.ReverseNumber(n));
                            break;
                        }
                    case 2:
                        {
                            int n; 
                            Console.Write("\nEnter integer number ----> ");

                            n = int.Parse(Console.ReadLine());
                            Console.Write("Reverse of " + n + " is " + Operations.BigestDigit(n));

                            break;
                        }
                    case 3:
                        {
                            string stringVal = "string 456";

                            Console.Write("Reverse of " + stringVal + " is " + Operations.FirstNum(stringVal));
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Number of element you need enter ");
                            int numberE = int.Parse(Console.ReadLine());

                            Console.Write( Operations.MaximumInput(numberE));

                            break; 

                        }


                    default:
                        {
                            if (choice == 5)
                            {
                                Console.WriteLine("Thanks for using");
                            }
                            else
                            {
                                Console.WriteLine("Choose a numer from 1 to 4 and 5 for end ");
                            }
                            break;
                        }
                }
            } while (choice != 5);






        }
    }
}
