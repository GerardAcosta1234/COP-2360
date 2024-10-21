
using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("enter in the first number:");
    string input1 = Console.ReadLine();

    Console.WriteLine("enter in the second number:");
    string input2 = Console.ReadLine();

    try
    {
      int number1 = Convert.ToInt32(input1);
      int number2 = Convert.ToInt32(input2);

      int result = Divide(number1, number2);
      Console.WriteLine($"The result of {number1} divided by {number2} is: {result}");
    }
    catch (FormatException ex)
    {
      Console.WriteLine("Error: One or both of the inputs are not valid integers");
      Console.WriteLine($"Detailed error message: The only inputs that can be converted to integers are numbers without decimal points under 32 bits");
    }
    catch (DivideByZeroException ex)
    {
      Console.WriteLine("Error: A division by zero is not allowed.");
      Console.WriteLine($"detailed error message: It is mathematically impossible to divide by zero");
    }
    catch (OverflowException ex)
    {
      Console.WriteLine("Error: one or both of the integers are too large to be represent as a 32 bit integer");
      Console.WriteLine($"Detailed error message: Integers are limited to 32 bits of information, numbers are too large.");
    }
    catch (Exception ex)
    {
      Console.WriteLine("An unexpected error occured.");
      Console.WriteLine($"Deatailed error message: {ex.Message}");
    }
  
Console.WriteLine("press Any key to exit....");
    Console.ReadKey();
  }

  static int Divide(int a, int b)
  {
    return a/b;
  }
}



  
