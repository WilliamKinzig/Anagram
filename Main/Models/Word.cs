using System;
using System.Collections.Generic;

namespace Anagram.Models
{
  public class Word
  {
    private string _word;
    private static List<String> _wordList = new List<String> {};

    public Word()
    {
      _word = "";
    }

    public Word(string word)
    {
      _word = word;
    }
    //Check if Unit Test setup correctly
    public bool Default()
    {
      return true;
    }

    public string GetWord()
    {
      return _word;
    }

    public void SetWord(string word)
    {
      _word = word;
    }

    public void Add(string word)
    {
      _wordList.Add(word);
    }

    public static void ClearAll()
    {
      _wordList.Clear();
    }

    public string GetWord(int i)
    {
      return _wordList[i];
    }

    public override bool Equals(Object o)
    {
      return false;
    }

    public override int GetHashCode()
    {
      return 0;
    }

    public bool Equals(Word word)
    {
      return (_word == word.GetWord());
    }

    public static bool operator ==(Word wordOne, Word wordTwo)
    {
      return (wordOne.GetWord() == wordTwo.GetWord());
    }

    public static bool operator !=(Word wordOne, Word wordTwo)
    {
      return !(wordOne.GetWord() == wordTwo.GetWord());
    }


  }
}
