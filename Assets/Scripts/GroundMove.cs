using UnityEngine;
using System.Collections;

public class GroundMove : MonoBehaviour {
	public static float speed = 3.5f;
	// Update is called once per frame
	void Update () {
		if (BirdControll.gameOver) {
			return;		
		}
		transform.Translate (Vector3.right*speed*Time.deltaTime);
		if(transform.position.x >= 7){
			transform.position = new Vector3(-7.323999f,transform.position.y,transform.position.z);
		}
	}
}
