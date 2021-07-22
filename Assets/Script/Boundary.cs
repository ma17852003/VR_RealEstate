using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if ((this.gameObject.transform.position.z < 30) ||
			(this.gameObject.transform.position.z > +85) ||
			(this.gameObject.transform.position.x < -4) ||
			(this.gameObject.transform.position.x > +53)) {
			this.gameObject.transform.position = new Vector3 (18.39f, -41f, 38.2f);
		}
	}
}
