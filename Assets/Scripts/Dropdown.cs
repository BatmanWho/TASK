using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropdown : MonoBehaviour {

	public RectTransform container;
	public bool isOpen;

	void Start () {
		container = transform.Find("Container").GetComponent<RectTransform>();
		isOpen = false;
	}

	void Update () {
		Vector3 scale = container.localScale;
		scale.y = Mathf.Lerp (scale.y, isOpen ? 1 : 0, Time.deltaTime*6);
		container.localScale = scale;
	}

	public void drop(){
		if (isOpen)
			isOpen = false;
		else
			isOpen = true;
	}
}
