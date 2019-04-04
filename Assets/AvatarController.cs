using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class AvatarController : MonoBehaviour {

    Animator myAnim;
	// Use this for initialization
	void Start ()
    {
        myAnim = GetComponent<Animator>();
	}
	
    public void ChangeAnimationStatus()
    {

    }
}
