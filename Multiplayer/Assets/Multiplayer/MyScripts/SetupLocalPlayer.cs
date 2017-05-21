using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SetupLocalPlayer : NetworkBehaviour {

	// Use this for initialization
	void Start () {
		if (isLocalPlayer) 
		{
			//GetComponent
			GetComponent<Animator> ().enabled = true;
			Camera.main.transform.position = this.transform.position - this.transform.forward * 3 + this.transform.up * 2;
			Camera.main.transform.LookAt (this.transform.position) ;
			Camera.main.transform.parent = this.transform;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
