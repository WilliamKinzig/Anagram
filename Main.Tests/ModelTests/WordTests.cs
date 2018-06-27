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
    public void Return_Anagram_Word_True()
    {
      //Eventual Tests
      Word wordOne = new Word("TestTwo");
      wordOne.Add("Test");
      string amalWord = wordOne.GetWord(0);
      Assert.AreEqual(true, "Test"==amalWord);
    }
    [TestMethod]
    public void Test_Word_List_True()
    {
      //Eventual Tests
      Word wordOne = new Word("TestList");
      List<String> list = new List<string> {"One","Two","Three"};
      wordOne.SetList(list);
      string amalWord = wordOne.GetWord(0);
      Assert.AreEqual(list[0],amalWord);
      amalWord = wordOne.GetWord(1);
      Assert.AreEqual(list[1],amalWord);
    }
    [TestMethod]
    public void Test_Is_Anagram_True()
    {
      //Eventual Tests
      Word wordOne = new Word("test");
      List<String> list = new List<string> {"estt","stte","Three"};
      Assert.AreEqual(true,wordOne.isAnagram(list[0]));
    }
    [TestMethod]
    public void Test_Is_Anagram_True_2nd()
    {
      //Eventual Tests
      Word wordOne = new Word("test");
      List<String> list = new List<string> {"estt","stte","Three"};
      Assert.AreEqual(true,wordOne.isAnagram(list[0]));
    }
    [TestMethod]
    public void Test_Is_Anagram_False_1st()
    {
      //Eventual Tests
      Word wordOne = new Word("test");
      List<String> list = new List<string> {"estt","stte","Three"};
      Assert.AreEqual(false,wordOne.isAnagram(list[2]));
    }
    [TestMethod]
    public void Test_Is_Anagram_False_2nd()
    {
      //Eventual Tests
      Word wordOne = new Word("test");
      List<String> list = new List<string> {"estt","stte","tttt"};
      Assert.AreEqual(false,wordOne.isAnagram(list[2]));
    }
  }
}
