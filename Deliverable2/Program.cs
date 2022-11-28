using System;

public class Program
{
    public static void Main()
    {
        string drink1 = "A";
        int drink1T = 0;
        string drink2 = "NA";
        int drink2T = 0;
        string responses;
        decimal Meal = 9.99M;
        decimal Abev = 5.99M;
        decimal NAbev = 2.75M;
        decimal checktotal = 0;


        Console.Write("Welcome to The Best Buffet how many guests are in your party");
        int size = Convert.ToInt32(Console.In.ReadLine());
        Console.WriteLine();


        if (size <= 6)
        {
            int[] guests = new int[size];

            Console.WriteLine();

            for (int i = 0; i < guests.Length; i++)
            {
                Console.Write("Guest " + i + " Would you like an alcoholic or nonalcoholic beverage? Please respond with A, for Alcoholic, and NA for NonAlcoholic");
                responses = Console.ReadLine().ToUpper();

                if (responses == drink1)
                {
                    drink1T++;
                }
                else if (responses == drink2)
                {
                    drink2T++;
                }
                Console.WriteLine();
            }
            checktotal = (drink1T * Abev) + (drink2T * NAbev) + (guests.Length * Meal);
            Console.WriteLine("You had " + drink1T + " alcoholic beverages " + drink2T + " Nonalcholic beverages and " + guests.Length + " meals, You're total is" + checktotal);
        }
        else
        {
            Console.Write("I'm sorry we cannot seat a party of that size");
        }
    }
}
