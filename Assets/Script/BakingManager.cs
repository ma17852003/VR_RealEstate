using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BakingManager : MonoBehaviour {

	enum BakeStates {NotBake, Baked};

	private BakeStates state = BakeStates.NotBake;
	private bool foodPassed = false;

	private GameObject bread;
	private GameObject cheese;



	void setState(BakeStates newstate){
		state = newstate;
	}

	public void handleTrigger()
	{
		print ("working");
		switch (state) {
		case BakeStates.NotBake:
			break;
		case BakeStates.Baked:
			setState (BakeStates.Baked);
			break;
		
		}
	}


	public void handleFoodTouchEvent()
	{
		switch (state) {
		case BakeStates.NotBake:
			foodPassed = true;
			updateFoodview ();
			break;
		case BakeStates.Baked:
			foodPassed = false;
			updateFoodview ();
			//setState (BakeStates.Baked);
			break;

		}
	}



	void updateFoodview()
	{
		if (foodPassed) {
			bread.GetComponent <MeshRenderer> ().material.color = new Color (0, 0, 0);

		} else {
			bread.GetComponent <MeshRenderer> ().material.color = new Color (0, 1, 0);

		}

		if (foodPassed) {
			cheese.GetComponent <MeshRenderer> ().material.color = new Color (0, 0, 0);

		} else {
			cheese.GetComponent <MeshRenderer> ().material.color = new Color (0, 1, 0);

		}


	}

	// Use this for initialization
	void Start () {
		
		bread = transform.Find ("bread").gameObject;
		cheese = transform.Find ("cheese").gameObject;

	}

	// Update is called once per frame
	void Update () {
		
	}
}
