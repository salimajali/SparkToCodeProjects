namespace SecondCsharpProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

        // Salima's First C Program : 

            Console.Write("Enter Your Name:  ");
            string UserName = Console.ReadLine();

            Console.Write("Enter Your Age:  ");
            int UserAge =int.Parse(Console.ReadLine());

            Console.Write("Enter Your Salary: ");
            float UserSalary =float.Parse(Console.ReadLine());

            Console.WriteLine("Welcome" + UserName + "Your Age: " + UserAge + "And Your Salary is: " + UserSalary);

            Console.ReadKey();            
        }
    }
}
