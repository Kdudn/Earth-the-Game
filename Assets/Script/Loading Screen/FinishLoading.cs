using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLoading : MonoBehaviour {
	[SerializeField] private Animator animator;
	private float loadTime;

	void Start()
	{
		float min = 23.0f;
		float max = 30.0f;

		loadTime = UnityEngine.Random.Range(min, max);
		StartCoroutine(ExecuteAfterDelay());
	}

	IEnumerator ExecuteAfterDelay()
	{
		yield return new WaitForSeconds(loadTime);
		animator.Play ("BlackIn");
	}

	public void finishLoading() {
		SceneManager.LoadScene("EarthGame");
	}
}
