using System;

namespace Practice
{
  class Program
  {
    static void Main(string[] args)
    {
      //Capitalize cap = new Capitalize();
      //cap.UpperCase();

      //RemoveChar remove = new RemoveChar();
      //remove.RemoveFirstsAndLastLetter();

      char operation = '+';
      double value1 = 4;
      double value2 = 7;
      MathOperation mathOperation = new MathOperation();
      Console.WriteLine(mathOperation.DoTheMath(operation, value1, value2)); 
    }
  }
}
