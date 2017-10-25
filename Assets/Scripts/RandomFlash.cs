using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomFlash : MonoBehaviour {
	Vector3 lightPosition;
	// Use this for initialization
	void Start () {
		lightPosition = new Vector3 (0, 0, 0);
		InvokeRepeating ("ChangePosition", 0, 2);
	}
	
	// Update is called once per frame
	void Update () {
        /*
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
        */
	}

	void ChangePosition () {
		transform.localPosition = lightPosition;
		lightPosition = new Vector3 (Random.Range (-5, 5), 0, Random.Range (-5,5));
	}
}
