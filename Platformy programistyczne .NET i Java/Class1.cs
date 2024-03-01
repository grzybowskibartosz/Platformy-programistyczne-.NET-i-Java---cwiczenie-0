using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Class1
{
    private int upperLimit;

    public Class1(int upperLimit)
    {
        this.upperLimit = upperLimit;
    }

    public void PrintFizzBuzz()
    {
        for (int i = 1; i <= upperLimit; i++)
        {
            if (i % 5 == 0 && i % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
