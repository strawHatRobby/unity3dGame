using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSound : MonoBehaviour {
	public GameObject kick;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			if (kick.activeSelf == true) {
				kick.SetActive (false);
			} else {
				kick.SetActive (true);
			}
		}
	}
}
