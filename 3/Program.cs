using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine("enter your number a ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter your number b ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter your number c ");
                int c = Convert.ToInt32(Console.ReadLine());

                if (a > 0 & b > 0 & c > 0 )
                {
                    Console.WriteLine("Your result is " + (a + b + c));
                }
                else if (a < 0 & b > 0 & c > 0 )
                {
                    Console.WriteLine("Your result is " + (b + c));
                }
                else if (a > 0 & b < 0 & c > 0 )
                {
                    Console.WriteLine("Your result is " + (a + c));
                }
                else if (a > 0 & b > 0 & c < 0)
                {
                    Console.Write("Your result is  " + (a + b));
                }
            else if (a > 0 & b < 0 & c < 0)
            {
                Console.Write("Your result is  " + a);
            }
            else if (a < 0 & b > 0 & c < 0)
            {
                Console.Write("Your result is  " + b);
            }
            else if (a < 0 & b < 0 & c > 0)
            {
                Console.Write("Your result is  " + c);
            }
        }
    }
    }