using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordTimer : MonoBehaviour {

    public WordManager wManager;
    public float wordDelay;     //change when it is necessary;
    private float nextWordTime = 0;

    private void Start()
    {
        SetWordTimerDelay();
    }

    // Update is called once per frame
    void Update () {

        if (Time.time >= nextWordTime)
        {
            wManager.AddWord();
            nextWordTime = Time.time + wordDelay;
        }
	}

    private void SetWordTimerDelay()
    {
        switch(Difficulty.difficulty)
        {
            case 1:
                nextWordTime = 3.5f;
                Debug.Log("Delay is: " + nextWordTime);
                break;
            case 2:
                nextWordTime = 2.5f;
                Debug.Log("Delay is: " + nextWordTime);
                break;
            case 3:
                nextWordTime = 1.5f;
                Debug.Log("Delay is: " + nextWordTime);
                break;
        }
    }

}
