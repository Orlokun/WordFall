using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour {


    public static string[] wordList = { "babyPenguin", "lomito", "churrasco", "mouse", "parlante", "luchoJara",
                                        "estricto", "fiscal", "desnudo",
                                        "aburrido", "contodo", "dale", "pf" };
                                       

    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string word = wordList[randomIndex];
        return word;
    }

}
