using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundTreeAnimation : MonoBehaviour {

	private static int times;
	private Vector3 temp;
	private Vector3 temp1;
	// Use this for initialization
	void Start () {
		times = 0;
		temp = temp1 = transform.position;
	}

	// Update is called once per frame
	void Update () {
		times++;
		temp.x -= times * 0.01f;
		if (temp.x < -20) {
			temp.x = temp1.x = 19.99f;
			times = 0;
		}
		transform.position = temp; 
		temp = temp1;
	}
}
