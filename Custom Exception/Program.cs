using System;

namespace CustomExceptionInCsharp
{
    // Custom exception class for age validation
    public class CustomEx_AGE : Exception
    {
        public CustomEx_AGE() : base("Age should be above 18")
        {
        }

        public CustomEx_AGE(string message) : base(message)
        {
        }

        public CustomEx_AGE(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int res = CheckAGE();
                Console.WriteLine(res);
            }
            catch (CustomEx_AGE ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            Console.ReadLine();
        }

        static int CheckAGE()
        {
            Console.WriteLine("Enter AGE:");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                // Throwing the custom exception if age is less than 18
                throw new CustomEx_AGE();
            }

            return age;
        }
    }
}
