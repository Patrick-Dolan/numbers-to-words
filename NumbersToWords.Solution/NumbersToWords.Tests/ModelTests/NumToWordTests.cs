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
  }
}

// Example Test Method Structure
//_________________________
// [TestMethod]
// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
// {
//   // any necessary logic to prep for test; instantiating new classes, etc.
//   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
// }