
using UnityEngine;

public class AutoResizeWindow : MonoBehaviour
{
	void Start()
	{
		Resolution resolution = Screen.currentResolution;

		int winHeight = Mathf.RoundToInt(0.71f * resolution.height);
		int winWidth = Mathf.RoundToInt((winHeight / 3f) * 4f);

		Screen.SetResolution(
			winWidth,
			winHeight,
			false
		);
	}
}