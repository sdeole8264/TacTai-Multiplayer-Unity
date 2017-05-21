using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NetworkAnimStates : MonoBehaviour {

	private string animStr = "Idle";
	public Animations CurrentAnim;
	public Animation animObj;
	public GameObject ThirdPersonPlayer;

	// Use this for initialization
	void Start () {
		CurrentAnim = Animations.idle;
	}
	
	// Update is called once per frame
	void Update () {
		//animation [animStr].speed = 1;

	}

	public void SyncAnimations(string AnimName)
	{
		CurrentAnim = (Animations)Enum.Parse(typeof(Animations), AnimName);
	}

	public enum Animations
	{
		idle,
		walk,
		run,
		jump
	}
}
