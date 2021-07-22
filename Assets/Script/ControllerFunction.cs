using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerFunction : MonoBehaviour {

	public GameObject head;
	public float speed = 0.01f;
	public GameObject left;
	public GameObject right;

	private GameObject grabbedObject = null;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		float trigger = Input.GetAxis ("ControllerTrigger");
		float grab = Input.GetAxis ("ControllerGrab");
		float pad = Input.GetAxis ("TrackPad");


		if (trigger > 0.5f) {

			print ("trigger " + trigger);
			this.transform.position += speed * head.transform.forward * Time.deltaTime;
			this.transform.position = new Vector3 (this.transform.position.x, -44.6f , this.transform.position.z);

		}
		if (grab > 0.5f) {

			print ("grabbing " + grab);

			if (left.GetComponent <CollisionCheck> ().thingImCollidingWith != null) {
				grabbedObject = left.GetComponent <CollisionCheck> ().thingImCollidingWith;
				grabbedObject.transform.SetParent (left.transform);
			}

			if (right.GetComponent <CollisionCheck> ().thingImCollidingWith != null) {
				grabbedObject = right.GetComponent <CollisionCheck> ().thingImCollidingWith;
				grabbedObject.transform.SetParent (right.transform);

			}

		} else {

			if (grabbedObject != null) {
				print ("realeasing" + grabbedObject.name);
				grabbedObject.transform.parent = null;
				grabbedObject = null;
			}

		}

	}

}
