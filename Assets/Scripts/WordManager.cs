using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour {

    public List<Word> wordList;
    public List<Word> activeWordList;
    public List<Word> wordsReady;
    public List<Word> mistakenWords;
    public List<string> wordsPassed;
    public int score = 0;
    public WordSpawner wSpawner;
    public AudioClipsManager aManager;
    private AvatarController avatarController;

    public void AddWord()
    {
        Word word = new Word(WordGenerator.GetRandomWord(), this, wSpawner.SpawnWord());
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
                    PlayWrongSound();
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
                    PlayReadyAudio();
                    score += word.score;
                    wordList.Remove(word);
                    wordsReady.Add(word);
                    //SaveInSystem();
                }
            }
            CleanActiveCompleteWords();
        }
    }

    public void PlayAvatarAnimation()
    {
        
    }

    public void CleanActiveCompleteWords()
    {
        foreach (Word word in wordsReady)
        {
            if (activeWordList.Contains(word))
            {
                activeWordList.Remove(word);
                word.wDisplay.RemoveWord();
            }
        }

        SaveWordsReady();
        wordsReady.Clear();
    }

    public void SaveInSystem()
    {
        ScoreSaver.SaveData(this);
    }

    public void SaveWordsReady()
    {
        foreach (Word word in wordsReady)
        {
            wordsPassed.Add(word.word);
        }
    }

    public void PlayTypeWriterSound()
    {
        AudioClipsManager aManager = FindObjectOfType<AudioClipsManager>();
        aManager.PlayTypeWriterSound();
    }

    public void PlayReadyAudio()
    {
        aManager.PlayGoodSound();
    }

    public void PlayWrongSound()
    {
        aManager.PlayErrorSound();
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
