using System.Collections.Generic;
namespace NumbersToWords.Models
{
  public class NumToWord
  {
    public string UserNumber { get; set; }
    public static Dictionary<char, string> Ones = new Dictionary<char, string>() {
      {'1', "one"},
      {'2', "two"},
      {'3', "three"},
      {'4', "four"},
      {'5', "five"},
      {'6', "six"},
      {'7', "seven"},
      {'8', "eight"},
      {'9', "nine"}
    };
    public static Dictionary<string, string> Teens = new Dictionary<string, string>() {
      {"10", "ten"},
      {"11", "eleven"},
      {"12", "twelve"},
      {"13", "thirteen"},
      {"14", "fourteen"},
      {"15", "fifteen"},
      {"16", "sixteen"},
      {"17", "seventeen"},
      {"18", "eighteen"},
      {"19", "nineteen"}
    };
    public static Dictionary<string, string> Tens = new Dictionary<string, string>() {
      {"20", "twenty"},
      {"30", "thirty"},
      {"40", "fourty"},
      {"50", "fifty"},
      {"60", "sixty"},
      {"70", "seventy"},
      {"80", "eighty"},
      {"90", "ninety"}
    };
    


    public NumToWord(string userNumber)
    {
      UserNumber = userNumber;
    }

    public string ConvertNumToWord()
    {
      string temp = UserNumber;
      string result = "";
      if (temp.Length == 2)
      {
        if (temp[0] == '1')
        {
          result = Teens[temp];  
        }
        else
        {
          result = Tens[temp[0].ToString() + "0"] + " " + Ones[temp[1]];
        }
      }
      else
      {
        foreach (char c in temp)
        {
          result = Ones[c];
        }
      }
      return result;
    }
  }
}
