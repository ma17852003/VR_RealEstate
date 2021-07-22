using UnityEngine;

public class Sliding_Door_Script : MonoBehaviour {

	public GameObject trigger;
	public GameObject door;

	Animator doorAnim;


	// Use this for initialization
	void Start () {

		doorAnim = door.GetComponent <Animator> ();


	}

	void OnTriggerEnter(Collider coll){
		if (coll.gameObject.tag == "DoorOpen") {
			SlideDoors (true);
		}
	}

	void OnTriggerExit(Collider coll){
		if (coll.gameObject.tag == "DoorOpen") {
			SlideDoors (false);
		}
	}

	void SlideDoors(bool state){
		doorAnim.SetBool ("slide", state);

	}


	// Update is called once per frame
	void Update () {
		
	}
}
