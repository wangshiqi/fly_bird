using UnityEngine;
using System.Collections;

public class GroundMove : MonoBehaviour {
	public float speed = 3.5f;
	// Update is called once per frame
	void Update () {
		if (BirdControll.gameOver) {
			return;		
		}
		transform.Translate (Vector3.right*speed*Time.deltaTime);
		if(transform.position.x >= 6.76f){
			transform.position = new Vector3(-6.76f,transform.position.y,transform.position.z);
		}
	}
}
