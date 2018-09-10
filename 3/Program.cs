using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter your number a ");
            int a = getNumber();
            Console.WriteLine("enter your number b ");
            int b = getNumber();
            Console.WriteLine("enter your number c ");
            int c = getNumber();

            int sum = 0;

            if (a > 0) sum += a;
            if (b > 0) sum += b;
            if (c > 0) sum += c;

            Console.WriteLine("Your result is " + sum);
        }

        private static Int32 getNumber()
        {
            string userInput = Console.ReadLine();

            try { return Convert.ToInt32(userInput); }
            catch
            {
                Console.WriteLine("Invalid input, please try again");
                return getNumber();
            }
        }
    }
}