using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class onClickStart : MonoBehaviour {

	private GameController gc_GameController;
	private Text t_gameStartText;

	void Awake (){
		gc_GameController = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();
		t_gameStartText = GetComponent<Text> ();
	}
	
	void Update () {
	 if (Input.GetButton ("Fire1")) {
			t_gameStartText.text = "";
			gc_GameController.b_gameStarted = true;
		}
	}
}
