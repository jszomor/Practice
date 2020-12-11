using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
  public class MathOperation
  {
    public double DoTheMath(char operation, double value1, double value2)
    {
      //switch(operation)
      //{
      //  case '+':
      //    return value1 + value2;
      //  case '-':
      //    return value1 - value2;
      //  case '*':
      //    return value1 * value2;
      //  case '/':
      //    return value1 / value2;
      //  default:
      //    return -1;
      //}
      return operation switch
      {
        '+' => value1 + value2,
        '-' => value1 - value2,
        '*' => value1 * value2,
        '/' => value1 / value2,
        _ => -1,
      };
    }
  }
}
