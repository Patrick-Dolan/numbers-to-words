namespace NumbersToWords.Models
{
  public class NumToWord
  {
    public string UserNumber { get; set; }
    public NumToWord(string userNumber)
    {
      UserNumber = userNumber;
    }
  }
}