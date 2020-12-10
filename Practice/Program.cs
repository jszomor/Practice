using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Practice
{
  class Program
  {
    static void Main(string[] args)
    {
      string phrase = "How can mirrors be real if our eyes aren't real";
      string[] words = phrase.Split(' ');
      string upperCaseLetter;
      List<string> upperWords = new List<string>();
      foreach (var word in words)
      {
        if(Char.IsLower(word[0]))
        {
          //word.First().ToString().ToUpper();
          upperCaseLetter = word.Replace(word[0], Char.ToUpper(word[0]));
          upperWords.Add(upperCaseLetter);     
        }
      }
      string upperPhrase = String.Join(" ", upperWords);
      Console.WriteLine(phrase);
      Console.WriteLine(upperPhrase);
      Console.WriteLine("How Can Mirrors Be Real If Our Eyes Aren't Real");

      string s = "How can mirrors be real if our eyes aren't real";
      s = Regex.Replace(s, @"(^\w)|(\s\w)", m => m.Value.ToUpper());
      Console.WriteLine(s);
      //return upperPhrase;
    }
  }
}
