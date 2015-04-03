using UnityEngine;
using System.Collections;

public class freezePlayer : MonoBehaviour {

	void Awake () {
		freezPlayer ();
	}

	public void UnFreezPlayer(){
		GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.None;
	}

	public void freezPlayer(){
		GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.FreezeAll;
	}
}
