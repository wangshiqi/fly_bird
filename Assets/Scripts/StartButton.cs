using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnClick(){
		//GameData data = new GameData ();
		//GameDataManager.instance.gameData.PlayerScore = 10;
		//GameDataManager.instance.Save ();
		//GameDataManager.instance.Load ();


		//Debug.Log (GameDataManager.instance.gameData.PlayerScore);
		Application.LoadLevel (1);
	}
}
