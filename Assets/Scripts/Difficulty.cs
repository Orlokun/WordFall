using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Difficulty
{
    private static int difficulty = 0;

    public static void SetDifficulty(int toughness)
    {
        difficulty = toughness;
    }

    public static int GetDifficulty()
    {
        return difficulty;
    }

}
