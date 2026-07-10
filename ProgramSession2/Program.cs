namespace ProgramSession2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Session 2..
                    /*
                     My Name is Salima 
                      */

            Console.WriteLine("Enter First Number");
            float FirstNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            float SecondNumber = float.Parse(Console.ReadLine());

            float additionResult = FirstNumber + SecondNumber;
            float subtractionResult = FirstNumber - SecondNumber;
            float mulitplcationResult = FirstNumber * SecondNumber;
            float divisionResult = FirstNumber / SecondNumber;
            float reminderResult = FirstNumber % SecondNumber;
            bool result = FirstNumber >= SecondNumber;

            Console.WriteLine("Addition Result is : " + additionResult);
            Console.WriteLine("Subtraction Result is : " + subtractionResult);
            Console.WriteLine("Multiplication Result is :  " + mulitplcationResult);
            Console.WriteLine("Division Result is : " + divisionResult);
            Console.WriteLine("Reminder Result is: " + reminderResult);
            Console.WriteLine(result);

            ///////////////////////////////////////////////////////

            Console.WriteLine("Enter Your Marks");
            float mark = float.Parse(Console.ReadLine());

            if (mark >= 0 && mark < 50)
            {

                Console.WriteLine("You Failed");
            }
            else if (mark >= 50 && mark < 60)
            {
                Console.WriteLine("You Passed with grade D ");
            }
            else if (mark >= 60 && mark < 70)
            {
                Console.WriteLine("You passed with grade C");
            }
            else
            {
                Console.WriteLine("You Entered a wrong Number");

            }

            ///////////////////////////////////////////////////////////
            
            Console.WriteLine("Welcome to Main Menu");
            Console.WriteLine("1. Deposite");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Balance Check");

            Console.WriteLine("Please choose an option");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("deposited");
                    break;

                case 2:
                    Console.WriteLine("withdrawed");
                    break;

                case 3:
                    Console.WriteLine("Your Balance is : ");
                    break;

                default:
                    Console.WriteLine("please choose a correct option");
                    break;

            }
        }
    }
}