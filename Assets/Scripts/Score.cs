using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	UILabel label;
	// Use this for initialization
	void Start () {
		label = GetComponent<UILabel>();
	}
	
	// Update is called once per frame
	void Update () {
		label.text = "Score:" + BirdControll.score;
	}
}
