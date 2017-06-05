using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickSound : MonoBehaviour {
	public static GameObject[] parentSequencer;

	public static GameObject sequncer;
	public float delay;
	public float counter;
	// Use this for initialization
	void Start () {
		parentSequencer = new GameObject[9];
//		parentSequencer [0] = GameObject.FindGameObjectWithTag ("1");
//		parentSequencer [1] = GameObject.FindGameObjectWithTag ("2");
//		parentSequencer [2] = GameObject.FindGameObjectWithTag ("3");
//		parentSequencer [3] = GameObject.FindGameObjectWithTag ("4");
//		parentSequencer [4] = GameObject.FindGameObjectWithTag ("5");
//		parentSequencer [5] = GameObject.FindGameObjectWithTag ("6");
//		parentSequencer [6] = GameObject.FindGameObjectWithTag ("7");
//		parentSequencer [7] = GameObject.FindGameObjectWithTag ("8");
//		parentSequencer [8] = GameObject.FindGameObjectWithTag ("9");

		for (int i = 0; i < parentSequencer.Length; i++) {
			parentSequencer [i] = GameObject.FindGameObjectWithTag ((i+1).ToString ());
		}



		for (int i = 0; i < parentSequencer.Length; i++) {
			parentSequencer [i].SetActive (false);
		}
		StartCoroutine (wait1 (0.5f));
//		counter = 0f;
//		delay = 1f;

	}
	
	// Update is called once per frame

	private IEnumerator wait1(float time) {
		int i = 0;
		yield return new WaitForSeconds (time);
		while (true && i < 9) {
			parentSequencer [i].SetActive (true);
			yield return new WaitForSeconds (time);
			parentSequencer[i].SetActive(false);
			i++;
			if (i == 9) {
				i = 0;
			}
		}

	}
}
