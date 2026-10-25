using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectOption : MonoBehaviour {
	[SerializeField] private List<GameObject> options;
	[SerializeField] private List<GameObject> selectScreens;
	[SerializeField] private GameObject earth;
	public Animator animator;
	private DisableSelf parentScript;
	private Animator earthAnimator;
	private int currentSelect;

	void Start () {
		animator = transform.parent.gameObject.GetComponent<Animator> ();
		parentScript = transform.parent.gameObject.GetComponent<DisableSelf> ();
		earthAnimator = earth.GetComponent<Animator> ();
		currentSelect = 0;
	}

	void Update () {
		for (int i = 0; i < options.Count; i++) {
			Text currentSelectText = options[i].GetComponent<Text>();
			if (i == currentSelect) {
				currentSelectText.text = "  " + options[i].name + " <";
			} else {
				currentSelectText.text = options[i].name;
			}
		}
		inputUpdates ();
	}

	void inputUpdates(){
		if (transform.parent.gameObject.activeSelf && parentScript.arrival) {
			if (Input.GetKeyDown (KeyCode.DownArrow)) {
				currentSelect = (currentSelect + 1) % options.Count;
			}

			if (Input.GetKeyDown (KeyCode.UpArrow)) {
				currentSelect = (currentSelect - 1 + options.Count) % options.Count;
			}
			if (Input.GetKeyDown (KeyCode.Return)) {
				updateSelect ();
			}
		}
	}

	void updateSelect(){
		switch(options[currentSelect].name)
		{
			case "Decade": 
				animator.Play ("TitleOut");
				selectScreens [currentSelect].SetActive (true);
				break;
			case "Exit":
				Application.Quit ();
				#if UNITY_EDITOR
					UnityEditor.EditorApplication.isPlaying = false;
				#endif
				break;
			case "Difficulty": 
				animator.Play ("TitleOut");
				selectScreens [currentSelect].SetActive (true);
				break;
		case "Play":
				animator.Play ("TitleOut");
				earthAnimator.Play ("Earth Out");
				break;
		}
	}
}
