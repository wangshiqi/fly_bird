using UnityEngine;
using System.Collections;

public class BirdControll : MonoBehaviour {
	public static bool gameOver = false;
	public static bool isStart = false;
	public static int score = 0;
	//public GameObject window;
	public GameObject teach;
	public AudioClip zhuangqiang;
	public AudioClip click;
	public GameObject zhangAi;
	bool isAddScore = false;
	bool isDrop = false;
	float jumpForce = 380.0f;
	Rigidbody2D rb;

	void Awake () {
		Application.targetFrameRate = 60;
	}
	// Use this for initialization
	void Start () {
		Screen.fullScreen = !Screen.fullScreen;
		//NGUITools.SetActive (window,false);
		rb = rigidbody2D;
		rb.Sleep ();
	}
	
	// Update is called once per frame
	void Update () {
		if (gameOver) {
			return;	
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			if(!isStart){
				for (int i = 1; i < 4; i++) {
					Instantiate(zhangAi,new Vector3(-5*i,Random.Range(2,-2)),Quaternion.identity);
				}
				isStart = true;
				NGUITools.SetActive(teach,false);
				rb.WakeUp();
			}
			audio.clip = click;
			audio.Play();
			//transform.rotation = rot;
			rb.AddForce (Vector2.up*jumpForce - rb.velocity * 55);
		}
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) {
			if(!isStart){
				for (int i = 1; i < 4; i++) {
					Instantiate(zhangAi,new Vector3(-5*i,Random.Range(2,-2)),Quaternion.identity);
				}
				isStart = true;
				NGUITools.SetActive(teach,false);
				rb.WakeUp();
			}
			audio.clip = click;
			audio.Play();
			rb.AddForce (Vector2.up*jumpForce - rb.velocity * 55);
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "zhangai"){
			if(GameDataManager.instance.gameData.PlayerScore < score){
				GameDataManager.instance.gameData.PlayerScore = score;
				GameDataManager.instance.Save();
				MaxScore.instance.ChangeScore(score);
			}
			if(!gameOver){
				audio.clip = zhuangqiang;
				audio.Play();
				rb.Sleep();
				ShakeCamera.shakeCamera();
			}
			gameOver = true; 
			StartCoroutine(ShowWindow());
		}else if (col.gameObject.tag == "score") {
			if(!isAddScore){
				score ++;
				Score.instance.ChangeScore(score);
				isAddScore = true;
			}
		}
	}

	void OnTriggerExit2D(Collider2D col){
		if (col.gameObject.tag == "score") {
			isAddScore = false;
		}
	}

	IEnumerator ShowWindow(){
		yield return new WaitForSeconds (0.5f);
		rb.WakeUp();
		yield return new WaitForSeconds (1);
		//NGUITools.SetActive (window,true);
	}
}
