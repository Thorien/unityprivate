using UnityEngine;
using System.Collections;

public class EngineBurst : MonoBehaviour {

	private ParticleSystem engineSystem;
	private GameObject engine;
	public int burstCount = 10;

	void Awake () {
		engineSystem = gameObject.GetComponent<ParticleSystem> ();
	}
	
	public void EmitBurst(){
		engineSystem.Emit (burstCount);
	}
}
