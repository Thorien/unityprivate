using UnityEngine;
using System.Collections;

public class ObstacleMover : MonoBehaviour {

	public float f_obstaclesSpeed = 4;
	public float f_leftBoundary = -10;
	public float f_rightBoundary = 10;
	public float f_randomScaleMin = 0.5f;
	public float f_randomScaleMax = 2f;
	public GameObject[] GO_obstacleMesh;
	public bool b_moveObstacle = false;

	void Awake (){
		GO_obstacleMesh = GameObject.FindGameObjectsWithTag("Obstacle");
	}

	// Update is called once per frame
	void Update () {
		if (b_moveObstacle) {
			transform.position = new Vector3 (transform.position.x - (f_obstaclesSpeed * Time.deltaTime),0f,0f);
			if (transform.position.x <= f_leftBoundary) {
				transform.position = new Vector3(f_rightBoundary,0f,0f);
				f_obstaclesSpeed++;
			}
		}
	
	}
}
