using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BakeCheck : MonoBehaviour {
	public BakingManager bread;
	public BakingManager cheese;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other){
		print ("Baked");
		bread.handleFoodTouchEvent ();
		cheese.handleFoodTouchEvent ();
	}
}
