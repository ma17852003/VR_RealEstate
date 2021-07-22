﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : StateMachineBehaviour {

	GameObject Robot;
	GameObject[] waypoints;
	int currentWp;

	void Awake()
	{
		waypoints = GameObject.FindGameObjectsWithTag ("waypoint");
	}

	 // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		Robot = animator.gameObject;
		currentWp = 0;
	}

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		if (waypoints.Length == 0)
			return;
		if (Vector3.Distance (waypoints [currentWp].transform.position,
			   Robot.transform.position) < 3.0f) {
			currentWp++;
			if (currentWp >= waypoints.Length) {
				currentWp = 0;
			}
		}

		var direction = waypoints [currentWp].transform.position - Robot.transform.position;
		Robot.transform.rotation = Quaternion.Slerp (Robot.transform.rotation, 
			Quaternion.LookRotation (direction),
			1.0f * Time.deltaTime);
		Robot.transform.Translate (0, 0, Time.deltaTime * 2.0f);


	}

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		
		}

	}
