using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("\nEnter string: ");
            string input = Console.ReadLine();

            if (input == "*")
                break;

            string lowerInput = input.ToLower();
            string reversed = "";

            
            for (int i = lowerInput.Length - 1; i >= 0; i--)
            {
                reversed += lowerInput[i];
            }

           
            string result = (lowerInput == reversed) ? "Yes" : "No";

           
            Console.WriteLine("\nOriginal String\tReversed String\tPalindrome?");
            Console.WriteLine($"  {input,-15}{reversed,-15}{result}");
        }

        Console.WriteLine("\n//End execution");
    }
}
