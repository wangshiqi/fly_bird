using UnityEngine;
using System.Collections;

public class ZhangaiMove : MonoBehaviour {

	// Use this for initialization
	float yMax = 2;
	float yMin = -2;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (BirdControll.gameOver) {
			return;		
		}
		transform.Translate (Vector3.right*GroundMove.speed*Time.deltaTime);
		if(transform.position.x >= 5){
			float y = Random.Range(yMin,yMax);
			transform.position = new Vector3(-10,y,0);
		}
	}
}
