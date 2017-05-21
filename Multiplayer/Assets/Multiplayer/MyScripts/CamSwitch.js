#pragma strict

public var FirstCamera : UnityEngine.Camera;
public var SecondCamera : UnityEngine.Camera;


function Update () {

if(Input.GetKeyDown("f")) {
FirstCamera.GetComponent.<Camera>().enabled = false;
SecondCamera.GetComponent.<Camera>().enabled = true;
}

if(Input.GetKeyDown("r")) {
FirstCamera.GetComponent.<Camera>().enabled = true;
SecondCamera.GetComponent.<Camera>().enabled = false;
}

}