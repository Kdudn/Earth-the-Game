using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultySelect : MonoBehaviour {
	private Animator animator;
	private DisableSelf parentScript;
	[SerializeField] private List<GameObject> difficulties;
	[SerializeField] private GameObject selectScreen;
	private int currentSelect;
	private RectTransform rectTransform;
	private Vector2 position;

	void Start()
	{
		animator = transform.parent.gameObject.GetComponent<Animator>();
		parentScript = transform.parent.gameObject.GetComponent<DisableSelf> ();
		rectTransform = GetComponent<RectTransform>();

		currentSelect = difficulties.FindIndex(difficulty => difficulty.name == GlobalScript.currentDifficulty);
		position = rectTransform.anchoredPosition;
		position.y = 70 * (currentSelect - 2);

		rectTransform.anchoredPosition = position;
	}

	void Update () {
		inputUpdate ();
	}

	void inputUpdate() {
		if (transform.parent.gameObject.activeSelf && parentScript.arrival) {
			if (Input.GetKeyDown(KeyCode.DownArrow)) {
				currentSelect = (currentSelect + 1) % difficulties.Count;
				position.y = 70 * (currentSelect - 2);
				rectTransform.anchoredPosition = position;
			}

			if (Input.GetKeyDown(KeyCode.UpArrow)) {
				currentSelect = (currentSelect - 1 + difficulties.Count) % difficulties.Count;
				position.y = 70 * (currentSelect - 2);
				rectTransform.anchoredPosition = position;
			}

			if (Input.GetKeyDown(KeyCode.Return)) {
				updateSelect();
			}
		}
	}

	void updateSelect(){
		GlobalScript.currentDifficulty = difficulties [currentSelect].name;
		selectScreen.SetActive (true);
		animator.Play ("DecadeOut");
		GlobalScript.saveGame ();
	}
}
