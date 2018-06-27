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

    public void SetList(List<String> list)
    {
      _wordList = list;
    }

    public List<String> GetList()
    {
      return _wordList;
    }

    //Obfuscated way
    public bool isAnagramConfusing(string anagram)
    {
      int[] charWord = new int[26];
      int countWord = 0;
      int[] charAnagram = new int[26];
      int countAna = 0;
      foreach (char c in _word)
      {
        charWord[(((int)char.ToUpper(c))-65)]++;
        countWord++;
      }
      foreach (char c in anagram)
      {
        charAnagram[(((int)char.ToUpper(c))-65)]++;
        countAna++;
      }
      if(countAna!=countWord)
      {
        return false;
      }
      for(int i = 0; i< 26;i++)
      {
        if(charWord[i] != charAnagram[i])
        {
          return false;
        }
      }
      return true;
    }

    public bool isAnagram(string anagram)
    {
      char[] wordArray = (_word.ToLower()).ToCharArray();
      char[] AnaArray = (anagram.ToLower()).ToCharArray();
      Array.Sort<char>(wordArray);
      Array.Sort<char>(AnaArray);
      if(wordArray.Length!=AnaArray.Length)
      {
        Console.WriteLine("Three");
        return false;
      }
      for(int i = 0; i<wordArray.Length;i++)
      {
        if(wordArray[i]!=AnaArray[i])
        {
          Console.WriteLine("One");
          return false;
        }
      }
      Console.WriteLine("Two");
      return true;
    }

    //Testing Not Related to Specs

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
