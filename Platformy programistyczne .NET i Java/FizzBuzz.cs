using System;

public class FizzBuzz
{
    private int upperLimit;

    public FizzBuzz(int upperLimit)
    {
        this.upperLimit = upperLimit;
    }

    public void PrintFizzBuzz()
    {
        for (int i = 0; i <= upperLimit; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (i % 5 == 0 && i % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wpisz gorny limit: ");
        int upperLimit = int.Parse(Console.ReadLine());

        // FizzBuzz fizzBuzz = new FizzBuzz(upperLimit);
        // fizzBuzz.PrintFizzBuzz();

        Class1 fizzBuzz_2 = new Class1(upperLimit);
        fizzBuzz_2.PrintFizzBuzz();

    }
}