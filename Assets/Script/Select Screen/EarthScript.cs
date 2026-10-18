using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EarthScript : MonoBehaviour {
	[SerializeField] private Animator animator;

	void Start () {
		animator.Play ("Earth In");
	}

	// Update is called once per frame
	void Update () {
		
	}

	public void startRotation(){
		animator.Play ("StartEarth");
	}

	public void loopAnim(){
		animator.Play ("StartEarth", 0, 0.56f);
		animator.Update (0f);
	}

	public void gotoLoading(){
		SceneManager.LoadScene ("Loading Screen");
	}
}
