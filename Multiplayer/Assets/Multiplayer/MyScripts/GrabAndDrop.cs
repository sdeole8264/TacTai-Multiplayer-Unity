using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabAndDrop : MonoBehaviour {
	GameObject grabbedObject;
	float grabbedObjectSize;
	// Use this for initialization

	GameObject GetMouseHoverObject(float range)
	{
		Vector3 position = gameObject.transform.position;
		RaycastHit raycastHit;
		Vector3 target = position + Camera.main.transform.forward * range;
		if (Physics.Linecast (position, target, out raycastHit)) 
		{
			return raycastHit.collider.gameObject;
		}
		return null;
	}

	void TryGrabObject(GameObject grabObject)
	{
		if (grabObject == null) 
		{
			return;
		}
		grabbedObject = grabObject;

	}

	void DropObject()
	{
		if (grabbedObject == null) {
			return;
		}
		grabbedObject = null;
	}

	// Update is called once per frame
	void Update () 
	{
		//Debug.Log (GetMouseHoverObject (5));
		if (Input.GetMouseButtonDown (1)) 
		{
			if (grabbedObject == null) 
			{
				TryGrabObject (GetMouseHoverObject (5));
			}
			else
			{
					DropObject();
			}
		}

		if (grabbedObject != null) 
		{
			Vector3 newPosition = gameObject.transform.position + Camera.main.transform.forward * grabbedObjectSize;
			grabbedObject.transform.position = newPosition;
		}

	}
}
