namespace conditinals_conway_david
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // asks user for whole number and assigns to integer variable 
            Console.WriteLine("Enter a whole number,");
            int myWholeNum = Convert.ToInt32(Console.ReadLine());
            // Checks if postive or negtive 
            if (myWholeNum >= 0)
            {
                Console.WriteLine($"{myWholeNum} is a positive number!");

            }
            else
            {
                Console.WriteLine($"{myWholeNum} is a negtive number!");

            }

            // check if even or odd 
            if (myWholeNum % 2 ==0) 
            { 
                Console.WriteLine($"{myWholeNum} is a even number!");
            }else
            {
                Console.WriteLine($"{myWholeNum} is a odd number!");
            }

            int num1 = 6;
            int num2 = 99;
            // gets fist max 
            int firstMax = Math.Max(myWholeNum, num1);
            // gets max number 
            int max = Math.Max(myWholeNum, num2);
            // prints max to console 
            Console.WriteLine($"The maximum number of {myWholeNum}, {num1}, and {num2} is {max}!");

            Console.WriteLine("Enter a grade (A, B, C, D ,F)!");
            char grade = Console.ReadKey().KeyChar;

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("\nSuperior");
                    break;
                case 'B':
                    Console.WriteLine("\nvery good");
                    break;
                case 'C':
                    Console.WriteLine("\navrage");
                    break;
                case 'D':
                    Console.WriteLine("\nbelow  average");
                    break;
                case 'F':
                    Console.WriteLine("\nFail");
                    break;
                default:
                    break;
            }
        }
    }
}