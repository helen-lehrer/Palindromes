namespace Palindromes
{
  public class Checker
  {
    public bool IsPalindrome(string userInput)
    {
      //make it into an array
      //for loop to check if array[i] == reversearray[i]
      //if its false at all return false
      char[] inputArray = userInput.ToCharArray();
      //char[] inputArray2 = Array.Reverse(userInput.ToCharArray);
      int cycles = inputArray.Length;
      //Array.Reverse(inputArray);
      //char[] reversedArray = Array.Reverse(inputArray);
      for (int i = 0; i < inputArray.Length; i++)
      {
        if (inputArray[i] != inputArray[cycles-1-i])
        {
          return false;
        }
      }
      return true;
    }
        public bool IsPalindromeNum(int userInput)
    {
      //make it into an array
      //for loop to check if array[i] == reversearray[i]
      //if its false at all return false
      char[] inputArray = userInput.ToString().ToCharArray();
      //char[] inputArray2 = Array.Reverse(userInput.ToCharArray);
      int cycles = inputArray.Length;
      //Array.Reverse(inputArray);
      //char[] reversedArray = Array.Reverse(inputArray);
      for (int i = 0; i < inputArray.Length; i++)
      {
        if (inputArray[i] != inputArray[cycles-1-i])
        {
          return false;
        }
      }
      return true;
    }
  }
}