using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableSelf : MonoBehaviour {
	public bool arrival = false;

	public void disableSelf(){
		gameObject.SetActive (false);
		arrival = false;
	}

	public void changeArrival(int newState){
		arrival = newState == 1;
	}
}
