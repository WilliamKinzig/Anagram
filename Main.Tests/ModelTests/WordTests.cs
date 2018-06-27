using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Anagram.Models;

namespace Anagram.Tests
{
  [TestClass]
  public class WordTest
  {
    private bool test = false;
    [TestInitialize]
    public void TestInit()
    {
      test = true;
      Word.ClearAll();
    }
    [TestMethod]
    public void Return_True()
    {
      //Eventual Tests
      Word word = new Word("TestOne");
      Assert.AreEqual(test, word.Default());
      test = false;
    }
    [TestMethod]
    public void Return_True_2nd()
    {
      //Eventual Tests
      Word word = new Word("TestTwo");
      Assert.AreEqual(test, word.Default());
    }
    [TestMethod]
    public void Return_Two_Words_Equals_True()
    {
      //Eventual Tests
      Word wordOne = new Word("TestTwo");
      Word wordTwo = new Word("TestTwo");
      Assert.AreEqual(test, wordOne.Equals(wordTwo));
    }
    [TestMethod]
    public void Return_Two_Words_Equals_True_2nd()
    {
      //Eventual Tests
      Word wordOne = new Word("TestTwo");
      Word wordTwo = new Word("TestTwo");
      Assert.AreEqual(test, wordOne==wordTwo);
    }
    [TestMethod]
    public void Return_Amalgram_Word_True()
    {
      //Eventual Tests
      Word wordOne = new Word("TestTwo");
      wordOne.Add("Test");
      string amalWord = wordOne.GetWord(0);
      Assert.AreEqual(true, "Test"==amalWord);
    }
  }
}
