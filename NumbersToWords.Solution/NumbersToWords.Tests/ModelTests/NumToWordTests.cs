using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords.Models;

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