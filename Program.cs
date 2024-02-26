using System;

namespace Inlämningsuppgifterkapitel6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(största(200, 201));
        }

        static int största(int tal1, int tal2)
        {
            if (tal1 > tal2)
            {
                return tal1;
            }

            else if (tal1 < tal2)
            {
                return tal2;
            }

            else
            {
                return tal1;
            }
        }

    }
}