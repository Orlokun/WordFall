using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordTimer : MonoBehaviour {

    public WordManager wManager;
    public float wordDelay = 2.5f;      //change when it is necessary;
    private float nextWordTime = 0;

	// Update is called once per frame
	void Update () {

        if (Time.time >= nextWordTime)
        {
            wManager.AddWord();
            nextWordTime = Time.time + wordDelay;
        }
	}
}
