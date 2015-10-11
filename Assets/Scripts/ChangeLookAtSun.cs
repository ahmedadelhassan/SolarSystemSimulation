using UnityEngine;
using System.Collections;

public class ChangeLookAtSun : MonoBehaviour {
	
	public GameObject target; // the target that the camera should look at
	
	void Start() {
		if (target == null) 
		{
			target = this.gameObject;
			Debug.Log ("ChangeLookAtSun target not specified. Defaulting to parent GameObject");
		}
	}
	
	// Called when MouseDown on this gameObject
	void OnMouseOver () {
		if (Input.GetMouseButtonDown (0)) {
			// change the target of the LookAtTarget script to be this gameobject.
			LookAtTarget.target = target;
			Camera.main.fieldOfView = 15 * target.transform.localScale.x;
		} 
		if (Input.GetMouseButtonDown (2)) {
			LookAtTarget.target = GameObject.Find("Sun");
			Camera.main.transform.LookAt(GameObject.Find("Sun").transform.position);
			Camera.main.fieldOfView = 40;
		}
	}
}
