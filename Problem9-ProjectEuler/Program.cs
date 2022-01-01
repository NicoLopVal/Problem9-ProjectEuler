using System;

namespace Problem9_ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {

            for(double a = 1; a <=1000; a++)
            {
                for(double b = a + 1; b <= 1000; b++)
                {
                    for(double c = b + 1; c <= 1000; c++)
                    {
                        if(a+b+c == 1000 && Math.Pow(a,2) + Math.Pow(b,2) == Math.Pow(c, 2))
                        {
                            Console.WriteLine("The Pythagorean triplet for which a + b + c = 1000 is: " + a + ", " + b + ", " + c);
                            Console.WriteLine("And its product is: " + (a*b*c));
                            
                        }
                    }
                }
            }
        }
    }
}
