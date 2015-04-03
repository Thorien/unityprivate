using UnityEngine;
using System.Collections;

public class PlaySceneery : MonoBehaviour {

	private float sceneRotationSpeed;
	private GameController gameController;
	public bool playScenery = false;
	private Vector3 nullPoint;

	void Start(){
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		gameController = gameControllerObject.GetComponent<GameController> ();
		sceneRotationSpeed = gameController.scenerySpeed;
		nullPoint = new Vector3 (0f, 2f, -10f);
	}

	// Update is called once per frame
	void Update () {
		if (playScenery) {
			transform.RotateAround(nullPoint, Vector3.up, -sceneRotationSpeed * Time.deltaTime);
		}
	}
}
