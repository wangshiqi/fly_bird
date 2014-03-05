using UnityEngine;
using System.Collections;

public class fire : MonoBehaviour {
	GameObject target;
	// Use this for initialization
	void Start () {
		target = GameObject.FindWithTag ("firepos");
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = target.transform.position;
	}
}
