using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords.Models;
using System;
using System.Collections.Generic;

namespace NumbersToWords.Tests
{
  [TestClass]
  public class NumToWordTests
  {
    [TestMethod]
    public void NumToWord_InstantiateNumToWord_NumToWord()
    {
      string number = "3";
      NumToWord newNumToWord = new NumToWord(number);
      Assert.AreEqual(typeof(NumToWord), newNumToWord.GetType());
    }
    [TestMethod]
    public void ConvertNumToWord_ConvertNumberThreeToWord_String()
    {
      string number = "3";
      NumToWord newNumToWord = new NumToWord(number);
      string result = newNumToWord.ConvertNumToWord();
      Assert.AreEqual("three", result);
    }
    [TestMethod]
    public void ConvertNumToWord_ConvertNumbersOneThroughNine_String()
    {
      List<string> numbersToConvert = new List<string> {"1", "2", "3", "4", "5", "6", "7", "8", "9"};
      List<string> ConvertedNumbers = new List<string> {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
      for (int i = 0; i <= 8; i++)
      {
        NumToWord newNumToWord = new NumToWord(numbersToConvert[i]);
        Console.WriteLine(i);
        Assert.AreEqual(ConvertedNumbers[i], newNumToWord.ConvertNumToWord());
      }
    }
    [TestMethod]
    public void ConvertNumToWord_ConvertNumberElevenToWord_String()
    {
      string number = "11";
      NumToWord newNumToWord = new NumToWord(number);
      string result = newNumToWord.ConvertNumToWord();
      Assert.AreEqual("eleven", result);
    }
    [TestMethod]
    public void ConvertNumToWord_ConvertNumbersElevenThroughNineteen_String()
    {
      List<string> numbersToConvert = new List<string> {"11", "12", "13", "14", "15", "16", "17", "18", "19"};
      List<string> ConvertedNumbers = new List<string> {"eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
      for (int i = 0; i <= 8; i++)
      {
        NumToWord newNumToWord = new NumToWord(numbersToConvert[i]);
        Console.WriteLine(i);
        Assert.AreEqual(ConvertedNumbers[i], newNumToWord.ConvertNumToWord());
      }
    }
    [TestMethod]
    public void ConvertNumToWord_ConvertNumberTwentyFourToWord_String()
    {
      string number = "24";
      NumToWord newNumToWord = new NumToWord(number);
      string result = newNumToWord.ConvertNumToWord();
      Assert.AreEqual("twenty four", result);
    }
    [TestMethod]
    public void ConvertNumToWord_ConvertTensThroughToNinety_String()
    {
      List<string> numbersToConvert = new List<string> {"10", "20", "30", "40", "50", "60", "70", "80", "90"};
      List<string> ConvertedNumbers = new List<string> {"ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety"};
      for (int i = 0; i <= 8; i++)
      {
        NumToWord newNumToWord = new NumToWord(numbersToConvert[i]);
        Console.WriteLine(i);
        Assert.AreEqual(ConvertedNumbers[i], newNumToWord.ConvertNumToWord());
      }
    }
  }
}