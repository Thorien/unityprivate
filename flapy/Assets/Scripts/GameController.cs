using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public float scenerySpeed = 10f;
	public bool b_gameStarted = false;

	private GameObject go_obstacleMover;
	private GameObject go_Player;
	private GameObject go_Scenery;


	void Awake (){
		go_obstacleMover = GameObject.Find("ObstacleMover");
		go_Player = GameObject.Find("Player");
		go_Scenery = GameObject.Find("Scenery");
	}

	void Update(){
		if (b_gameStarted) {
			if (go_Player != null){
				go_Player.GetComponent<freezePlayer>().UnFreezPlayer();
			}

			go_obstacleMover.GetComponent<ObstacleMover>().b_moveObstacle = true;
			go_Scenery.GetComponent<PlaySceneery>().playScenery = true;
		}
	}
}
