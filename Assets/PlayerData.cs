using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class PlayerData
{
    private List<string> wordsReady;
    private int score;    

    public PlayerData(WordManager gameData)
    {
        wordsReady = gameData.wordsPassed;
        int score = gameData.score;
    }

}
