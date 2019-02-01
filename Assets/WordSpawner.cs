using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour {

    public GameObject wordPrefab;
    public Transform wordCanvas;

    public WordDisplay SpawnWord()
    {
        GameObject wordObject = (GameObject)Instantiate(wordPrefab, wordCanvas);
        WordDisplay wDisplay = wordObject.GetComponent<WordDisplay>();

        return wDisplay;
    }
} 
