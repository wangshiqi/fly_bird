using UnityEngine;
using System.Collections;

public class Retry : MonoBehaviour {
	void OnClick(){
		BirdControll.gameOver = false;
		BirdControll.score = 0;
		BirdControll.isStart = false;
		Application.LoadLevel (1);
	}
}
