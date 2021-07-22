using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck : MonoBehaviour {

	public GameObject thingImCollidingWith = null;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void OnTriggerEnter(Collider other)
	{
		print ("Collide with" + other.name);
		thingImCollidingWith = other.gameObject;
	}

	public void OnTriggerExit(Collider other)
	{
		print ("No collision" + other.name);
		thingImCollidingWith = null;
	}




}
