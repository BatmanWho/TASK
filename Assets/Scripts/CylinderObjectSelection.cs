using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderObjectSelection : MonoBehaviour {

	public GameObject Cube;
	public GameObject Sphere;
//	GameObject Cylinder;

	public float speed=20f;

	public bool isCurrent;

	void Awake () {
		isCurrent = false;
	}

	void Update () {
		if (isCurrent) {
    		transform.Rotate (Vector3.right, speed * Time.deltaTime);
		}
	}
	void OnDisable(){
		isCurrent = false;
	}

	public void CylinderClick(){
		Debug.Log("CYLINDER");
		if (!isCurrent) {
			Debug.Log("DISPLAY");
			isCurrent = true;
			Sphere.SetActive (false);
			Cube.SetActive (false);
			gameObject.SetActive (true);
		} else {
			Debug.Log("NOT DISPLAY");
			isCurrent = false;
			gameObject.SetActive (false);
		}
	}
}