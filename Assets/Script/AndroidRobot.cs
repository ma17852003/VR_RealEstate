using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidRobot : MonoBehaviour {


	public float speed = 5f;
	private GameState CurrentSate;

	public enum GameState
	{
		stateMoveForward,
		stateMoveRight,
		stateDestroy,
	}

	// Use this for initialization
	void Start () 
	{
		//GameState state = GameState.stateMove;
		SetCurrentState(GameState.stateMoveForward);

	}


	void SetCurrentState(GameState state)
	{
		CurrentSate = state;  ////???

	}
	// Update is called once per frame
	void Update () 
	{
		switch(CurrentSate)
		{
		case GameState.stateMoveForward:	
			this.transform.Translate (this.transform.forward * speed * Time.deltaTime);
			break;

		case GameState.stateMoveRight:
			//this.GetComponent<MeshRenderer> ().material.color = new Color (1, 1, 0);
			this.transform.Translate (this.transform.right * speed * Time.deltaTime);
			//Timeup();
			break;

		case GameState.stateDestroy:
			this.transform.Translate (this.transform.forward * speed * Time.deltaTime);
			this.GetComponent<MeshRenderer> ().material.color = new Color (0, 1, 2);
			SetCurrentState(GameState.stateMoveForward);
			break;
		}

	}

	void OnCollisionEnter(Collision bground)//A
	{
		switch (CurrentSate) 
		{
		case GameState.stateMoveForward:	
			if (bground.gameObject.name != "ground") 
			{	
				SetCurrentState (GameState.stateDestroy);
			}
			break;
		}
	}

	void Timeup()
	{
		StartCoroutine (runTimer (3.0f)); 
	}

	IEnumerator runTimer (float delay)
	{
		for(float i= 0.0f;i<delay; i+= 0.1f)
		{
			yield return new WaitForSeconds(0.1f);// fix method
			onpartialTimer(i);//link to onpartialTimer

		} //generate timer expired event
		SetCurrentState(GameState.stateDestroy);

	}

	void onpartialTimer(float Howmuchtimepassed)
	{
		print ("Timer value: " + Howmuchtimepassed);//display the time counting
	}

	public void OnTriggerEnter(Collider other)
	{
		print ("Destroy" + other.name);
		Destroy(other.gameObject);
	}
}