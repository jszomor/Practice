using System;

namespace Practice
{
  public class RemoveChar
  {
    public void RemoveFirstsAndLastLetter()
    {
      string s = "aéjfwrarvergwetg";

      //s = s.Remove(s.Length-1);
      //s = s.Remove(0,1);

      s = s.Substring(1, (s.Length - 2));

      Console.WriteLine(s);
    }
  }
}
