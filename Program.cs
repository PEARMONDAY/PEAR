using System;

namespace _63_082
{
    class Program
    {
        static void Main(string[] args)
        {
            string A;
            Console.Write("Aff :");
            A = Console.ReadLine();
            int a, b1, b2, b4, c3, c5, c6, p1, p3, pp;
            Console.Write("Pass :");
            a = int.Parse(Console.ReadLine());

            if(a>=0 && a <1000000)
            {
                if (A == "CIA")
                {
                    b1 = a % 10;
                    if (b1 % 3 == 0)
                    {
                        b2 = a / 10;
                        if (b2 % 10 != 1 && b2 % 1 != 3 && b2 % 10 != 5)
                        {
                            b4 = a / 1000;
                            if (b4 % 10 >= 6 && b4 % 10 != 8)
                            {
                                Console.WriteLine("True");
                            }
                            else
                                Console.WriteLine("False");
                        }
                        else
                            Console.WriteLine("False");
                    }
                    else
                        Console.WriteLine("False");
                }
                if (A == "FBI")
                {
                    c6 = a / 100000;
                    if (c6 >= 4 && c6 <= 7)
                    {
                        c3 = a / 100;
                        if (c3 % 10 == 2 || c3 % 10 == 4 || c3 % 10 == 8)
                        {
                            c5 = a / 10000;
                            if (c5 % 2 == 1)
                            {
                                Console.WriteLine("True");
                            }
                            else
                                Console.WriteLine("False");
                        }
                        else
                            Console.WriteLine("False");
                    }
                    else
                        Console.WriteLine("false");
                }
                if (A == "NSA")
                {
                    p1 = a % 10;
                    if (p1 == 1 || p1 == 2 || p1 == 3 || p1 == 5 || p1 == 6)
                    {
                        p3 = a / 100;
                        if (p3 % 3 == 0 || p3 % 2 != 0)
                        {
                            bool Pass = a.ToString().Contains(7.ToString());
                            if (Pass)
                            {
                                Console.WriteLine("True");
                            }
                            else
                                Console.WriteLine("False");
                        }
                        else
                            Console.WriteLine("False");
                    }
                    else
                        Console.WriteLine("False");
                }
                else
                    Console.WriteLine("ERROR");
            }
        }
    }
}
