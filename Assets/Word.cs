using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Word
{
    public WordManager wManager;
    public string word;
    private int typeIndex;

    public Word(string _word, WordManager _wManager)
    {
        word = _word;
        typeIndex = 0;
        wManager = _wManager;
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
        wManager.RemoveActiveWord(this);
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
