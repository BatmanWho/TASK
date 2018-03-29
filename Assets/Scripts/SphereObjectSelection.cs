using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereObjectSelection : MonoBehaviour {

	public GameObject Cube;
//	GameObject Sphere;
	public GameObject Cylinder;

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

	public void SphereClick(){
		Debug.Log("SPHERE");
		if (!isCurrent) {
			Debug.Log("DISPLAY");
			isCurrent = true;
			Cube.SetActive (false);
			Cylinder.SetActive (false);
			gameObject.SetActive (true);
		} else {
			Debug.Log("NOT DISPLAY");
			isCurrent = false;
			gameObject.SetActive (false);
		}
	}
}