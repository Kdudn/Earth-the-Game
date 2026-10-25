using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLoading : MonoBehaviour {
	[SerializeField] private Animator animator;
	[SerializeField] private GameObject space;
	private Animator spaceAnimator;
	private float loadTime;

	void Start()
	{
		spaceAnimator = space.GetComponent<Animator> ();

		float min = 23.0f;
		float max = 30.0f;

		loadTime = UnityEngine.Random.Range(min, max);
		if (GlobalScript.currentDecade != "Inf Loading") {
			StartCoroutine (ExecuteAfterDelay ());
		}
	}

	void Update(){
		inputUpdate ();
	}

	IEnumerator ExecuteAfterDelay()
	{
		yield return new WaitForSeconds(loadTime);
		animator.Play ("BlackIn");
	}

	public void finishLoading() {
		SceneManager.LoadScene("EarthGame");
	}

	void inputUpdate(){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (GlobalScript.currentDecade == "Inf Loading") {
				spaceAnimator.Play ("SpaceOut");
			}
		}
	}
}
