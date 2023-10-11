using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter two numbers
            Console.Write("Enter the first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            // Calculate and display the sum and product
            double sum = number1 + number2;
            double product = number1 * number2;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Product: {product}");

            // Integer overflow demonstration
            int integerToOverflow = int.MaxValue; // Initialize with the maximum value
            Console.WriteLine($"Starting integer value: {integerToOverflow}");

            // Use unchecked context to demonstrate overflow
            unchecked // to ignore error
            {
                integerToOverflow++; // integerToOverflow = integerToOverflow + 1
            }

            Console.WriteLine($"Overflowed integer value: {integerToOverflow}");
            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Integer overflow demonstration (decreasing the value)
            int integerToOverflow2 = int.MinValue; // Initialize with the minimum value
            Console.WriteLine($"Starting integer value: {integerToOverflow2}");

            // Keep subtracting 1 until it overflows
            unchecked
            {
                integerToOverflow2--;
            }

            Console.WriteLine($"Overflowed integer value: {integerToOverflow2}");
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Integer underflow demonstration
            int integerToUnderflow = int.MinValue; // Initialize with the minimum value
            Console.WriteLine($"Starting integer value: {integerToUnderflow}");

            try
            {
                // Try to subtract 1, which will cause an underflow and throw an exception
                checked
                {
                    integerToUnderflow--;
                }

                Console.WriteLine($"New integer value: {integerToUnderflow}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Underflow occurred. Integer value is out of range.");
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////
            // Convert an integer to a short
            int intValue = int.MaxValue;
            short shortValue = (short)intValue;

            Console.WriteLine($"Converted int to short: {shortValue}");
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            int intValue1 = 50000; // Een waarde die buiten het bereik van short ligt
            short shortValue1 = (short)intValue1; // Dit zal een foutmelding veroorzaken
            Console.WriteLine($"Converted int to short: {shortValue1}");
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            int intValue2 = 100; // Een waarde binnen het bereik van short
            short shortValue2 = (short)intValue2; // Geen foutmelding
            Console.WriteLine($"Converted int to short: {shortValue2}");



            Console.WriteLine($"the end");
        }
    }
}
