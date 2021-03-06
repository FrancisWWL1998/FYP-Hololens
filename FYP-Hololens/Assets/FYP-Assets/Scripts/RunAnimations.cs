﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAnimations : MonoBehaviour {

	ActivateBooth MotherBooth;
	public Animator actor;

	// Use this for initialization
	void Start ()
	{
		MotherBooth = (ActivateBooth)FindObjectOfType(typeof(ActivateBooth));
		actor.SetTrigger("idle");
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (MotherBooth.GetCollisionCheck())
		{
			Time.timeScale = 1;
			actor.SetTrigger("jump");
		}
		else
		{
			Time.timeScale = 0.2f;
		}
	}
}
