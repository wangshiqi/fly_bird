using UnityEngine;
using System.Collections;

public class MaxScore : MonoBehaviour {
	public static MaxScore instance;
	UILabel label;

	// Use this for initialization
	void Start () {
		instance = this;
		label = GetComponent<UILabel>();
		label.text = "Best:" + GameDataManager.instance.gameData.PlayerScore.ToString();
	}

	public void ChangeScore(int Score){
		label.text = "Best:" + Score.ToString();
	}
}
