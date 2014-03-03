using UnityEngine;
using System.Collections;

public class Retry : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnClick(){
		BirdControll.gameOver = false;
		BirdControll.score = 0;
		BirdControll.isStart = false;
		Application.LoadLevel (1);
	}
}
