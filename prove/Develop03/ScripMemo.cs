using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Reference
{
    private string _book;
    private int _verseStart;
    private int _verseEnd;

    public Reference(string book, int verseStart)
    {
        _book = book;
        _verseStart = verseStart;
        _verseEnd = verseStart;
    }

    public Reference(string book, int verseStart, int verseEnd)
    {
        _book = book;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }

    public string GetReference()
    {
        return _verseStart == _verseEnd ?
            $"{_book} {_verseStart}" :
            $"{_book} {_verseStart}-{_verseEnd}";
    }
}
 
public class Word
{
   private string _word ;
   private bool _isHidden ;
   public  Word(string word)
    {
        _isHidden = false;
        _word = word;
    }
    public string GetShow()
    {
        if (_isHidden == true)
        {
            return "_______";
        }
        else
        {
            return _word;
        }
    
    }
    public bool Hide()
    {
        if (_isHidden == false)
        {
            _isHidden = true;
        }
        return _isHidden;
    }
    
}

public class Scripture
{
    private string _reference;
    private Random _rand;
    private List<Word> _words = new List<Word>();

    public Scripture(string reference, string vers)
    {
        string[] wordsArray = vers.Split(' ');
        _reference = reference;
        _rand = new Random();
        foreach (string word in wordsArray)
        {
            Word w = new Word(word);
            _words.Add(w);
        }  
    }

      public void HideRandomWords()
    {
    
        for (int i = 0; i < 2; i++)
        {
          int index =  _rand.Next(_words.Count);//Get Ramdom index
          Word w = _words[index];// acces to _words[index]
          w.Hide();//call Hide in that word 
        }

    }
        public string GetRenderedText()
    {
            string gotRend = "";

            foreach (Word w in _words)
            {
                string piece = w.GetShow();
                gotRend += piece + " ";
            }

            return gotRend.Trim();
    }


}

