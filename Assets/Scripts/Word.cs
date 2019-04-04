using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Word
{
    public WordDisplay wDisplay;
    public WordManager wManager;
    public string word;
    private int typeIndex;
    public int score; 

    public Word(string _word, WordManager _wManager, WordDisplay _wDisplay)
    {
        word = _word;
        typeIndex = 0;
        wManager = _wManager;
        wDisplay = _wDisplay;
        wDisplay.SetWord(word);
        wDisplay.SetWordSizeAndColor();

    }

    public char GetNextLetter()
    {
        return word[typeIndex];
    }

    public void TypeLetter()
    {
        typeIndex++;
        wDisplay.RemoveLetter();
        wManager.PlayTypeWriterSound();

    }

    public void ResetWord()
    {
        typeIndex = 0;
        wManager.mistakenWords.Add(this);
        wDisplay.RestartWordDisplay();
    }

    public bool IsReady()
    {
        if (typeIndex >= word.Length)
        {
            return true;
        }
        return false;
    }
}
