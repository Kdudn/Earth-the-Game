using UnityEngine;

public static class GlobalScript {
	public static string currentDecade;
	public static string currentDifficulty;

	static GlobalScript() {
		currentDecade = PlayerPrefs.GetString("Current Decade", "2010's");
		currentDifficulty = PlayerPrefs.GetString("Current Difficulty", "Normal");
	}
	public static void saveGame(){
		PlayerPrefs.SetString ("Current Decade", currentDecade);
		PlayerPrefs.SetString ("Current Difficulty", currentDifficulty);
		PlayerPrefs.Save ();
	}
}