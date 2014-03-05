using UnityEngine;
using System.Collections;

public class Splash : MonoBehaviour {
	float time;
	float timelen = 3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (time > timelen) {
			Application.LoadLevel(1);		
		}
	}
}
