using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes;

namespace Palindromes.Tests
{
  [TestClass]
  public class PalindromesTests
  {
    [TestMethod]
    public void IsPalindrome_IsItAPalindrome_True()
    {
      Checker checker = new Checker();
      Assert.AreEqual(true, checker.IsPalindrome("eevee"));
    }
    [TestMethod]
    public void IsPalindromeNum_IsItAPalindrome_True()
    {
      Checker checker = new Checker();
      Assert.AreEqual(true, checker.IsPalindromeNum(101));
    }
  }
}