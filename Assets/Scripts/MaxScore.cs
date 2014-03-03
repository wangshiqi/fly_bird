using UnityEngine;
using System.Collections;

public class MaxScore : MonoBehaviour {
	UILabel label;
	// Use this for initialization
	void Start () {
		label = GetComponent<UILabel>();
	}
	
	// Update is called once per frame
	void Update () {
		label.text = "MaxScore:" + GameDataManager.instance.gameData.PlayerScore.ToString();
	}
}
