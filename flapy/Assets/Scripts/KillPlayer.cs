using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour {

	void OnTriggerExit(Collider other) {
		if (other.tag == "Player") {
			Destroy(other.gameObject);
		}
	}
}
