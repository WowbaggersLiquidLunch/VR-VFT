using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomFlash : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Renderer renderer = GetComponent<Renderer> ();
		Material mat = renderer.material;
//		float status = Mathf.PingPong ((Time.time + Random.Range(0.0f, 1.0f)), 10.0f);
		Color offColor = Color.black;
		Color onColor = Color.white;
		Color finalColor;
//		if (status / 5 > 1) {
//			finalColor = onColor;
//		} else {
//			finalColor = offColor;
//		}
		if (Time.time % 10 > 5) {
			finalColor = onColor;
		} else {
			finalColor = offColor;
		}
		mat.SetColor ("_EmissionColor", finalColor);
	}
}
