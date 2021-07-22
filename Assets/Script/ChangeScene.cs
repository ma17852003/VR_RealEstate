using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	string scene1 = "House";
	void Update(){
		/*float trigger = Input.GetAxis ("ControllerTrigger");

		if (trigger > 0.5f) {
			SceneManager.LoadScene ("House");
		}*/
	}
	void OnTriggerEnter(Collider hit)
	{

		if (hit.tag == "Start") 
		{
			SceneManager.LoadScene (scene1);
		}
		if (hit.tag == "Option") 
		{
			SceneManager.LoadScene (scene1);
		}
		if (hit.tag == "Exit") 
		{
			SceneManager.LoadScene (scene1);
		}
	}
}

