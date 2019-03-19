using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour {


    public static string[] wordList = { "baby Penguin", "lomito", "churrasco", "mouse", "parlante", "lucho jara",
                                        "estricto", "fiscal", "desnudo", "camión", "mansión", "bolígrafo", "&;:",
                                        "aburrido", "con todo", "dale", "pf" };
                                       

    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string word = wordList[randomIndex];
        return word;
    }

}
