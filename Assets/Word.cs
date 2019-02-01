using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Word
{
    private WordDisplay wDisplay;
    public WordManager wManager;
    public string word;
    private int typeIndex;

    public Word(string _word, WordManager _wManager, WordDisplay _wDisplay)
    {
        word = _word;
        typeIndex = 0;
        wManager = _wManager;
        wDisplay = _wDisplay;
        wDisplay.SetWord(word);

    }

    public char GetNextLetter()
    {
        return word[typeIndex];
    }

    public void TypeLetter()
    {
        typeIndex++;
        //Removeletter onscreen
    }

    public void ResetWord()
    {
        typeIndex = 0;
        wManager.mistakenWords.Add(this);
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
