using UnityEngine;
using System.Collections;

public class BumpPlayer : MonoBehaviour {

	public float bumpForce;
	public float doubleClikcDiff;
	public GameObject player;
	public GameObject engineSystem;
	private float lastClick;

	void Awake (){
		engineSystem = GameObject.Find("Engine");
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			engineSystem.GetComponent<EngineBurst>().EmitBurst();
			engineSystem.GetComponent<ParticleSystem>().Play();

			if( (Time.time - lastClick) < doubleClikcDiff){
				player.transform.GetComponent<Rigidbody>().velocity = new Vector3 (0f, bumpForce * 2, 0f);
				//Debug.Log ("Double click :" + (Time.time - lastClick) );
			} else {
				player.transform.GetComponent<Rigidbody>().velocity = new Vector3 (0f, bumpForce, 0f);
			}
			lastClick = Time.time;
		}
	}
}
