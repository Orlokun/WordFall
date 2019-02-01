using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour {

    public List<Word> wordList;
    public List<Word> activeWordList;
    public List<Word> wordsReady;
    public List<Word> mistakenWords;


    private void Start()
    {
        AddWord();
        AddWord();
        AddWord();
    }

    public void AddWord()
    {
        Word word = new Word(WordGenerator.GetRandomWord(), this);
        wordList.Add(word);
    }

    public void RemoveActiveWord(Word word)
    {
        activeWordList.Remove(word);
    }

    public void TypeLetter (char letter)
    {
        if (activeWordList.Count > 0)
        {
            foreach (Word word in activeWordList)
            {
                if (word.GetNextLetter() == letter)
                {
                    word.TypeLetter();
                }
                else
                {
                    word.ResetWord();
                }
            }
            RemoveActiveWrongTypedWords();
        }
        else
        {
            foreach (Word word in wordList)
            {
                if (word.GetNextLetter() == letter)
                {
                    activeWordList.Add(word);
                    word.TypeLetter();
                }
            }
        }

        if (activeWordList.Count > 0)
        {
            foreach (Word word in activeWordList)
            {
                if (word.IsReady())
                {
                    wordList.Remove(word);
                    wordsReady.Add(word);
                }
            }
            CleanActiveCompleteWords();
        }
    }

    public void CleanActiveCompleteWords()
    {
        foreach (Word word in wordsReady)
        {
            if (activeWordList.Contains(word))
            {
                activeWordList.Remove(word);
            }
        }
        wordsReady.Clear();
    }

    public void RemoveActiveWrongTypedWords()
    {
        foreach (Word word in mistakenWords)
        {
            if (activeWordList.Contains(word))
            {
                activeWordList.Remove(word);
            }
        }
        mistakenWords.Clear();
    }
}
