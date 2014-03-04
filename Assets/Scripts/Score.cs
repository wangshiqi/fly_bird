using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	public static Score instance;
	UILabel label;
	// Use this for initialization
	void Start () {
		instance = this;
		label = GetComponent<UILabel>();
	}

	public void ChangeScore(int Score){
		label.text = Score.ToString();
	}
}
