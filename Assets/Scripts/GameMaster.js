#pragma strict

static var zero : int = 0; 
static var TextWidth : int = Screen.width/4;
public static var savedLevel : String;
var i : int; 
i = Application.loadedLevel;
var CTime : UnityEngine.UI.Text;
var HTime : UnityEngine.UI.Text;

function Start () {
	Debug.Log (Application.loadedLevelName);
	PlayerPrefs.SetInt("savedLevel", i);
	PlayerPrefs.SetInt("paused", 1);
	Time.timeScale = PlayerPrefs.GetInt("paused");
}

function Update () {
	//time text
	CTime.text = "Current Time: " + Time.timeSinceLevelLoad;
	if(zero >= PlayerPrefs.GetInt("Best" + Application.loadedLevelName)) {
		HTime.text = "No best time!!!";
	} else if(zero <= PlayerPrefs.GetInt("Best" + Application.loadedLevelName)) {
		HTime.text = "Best Time: " + PlayerPrefs.GetInt("Best" + Application.loadedLevelName) + " seconds";
	}
	
	Time.timeScale = PlayerPrefs.GetInt("paused"); // Set pause or naw
	
	if (PlayerPrefs.GetInt("Endpoint") == 1 && PlayerPrefs.GetInt("Endpoint2") == 1) {
		//reseting playerprefs
		PlayerPrefs.SetInt("Endpoint", 0);
		PlayerPrefs.SetInt("Endpoint2", 0);
		//setting new level continuation
		PlayerPrefs.SetInt("savedLevel", i + 1);
		if(Time.timeSinceLevelLoad <= PlayerPrefs.GetInt("Best" + Application.loadedLevelName)) {
			PlayerPrefs.SetInt("Best" + Application.loadedLevelName, Time.timeSinceLevelLoad);
			//saving playerPrefs
		} else if(zero <= PlayerPrefs.GetInt("Best" + Application.loadedLevelName)) {
			PlayerPrefs.SetInt("Best" + Application.loadedLevelName, Time.timeSinceLevelLoad);
			//saving playerPrefs
		}
		if (Application.loadedLevelName == "Level10" || Application.loadedLevelName == "2Level10" || Application.loadedLevelName == "3Level10") {
			Application.LoadLevel("MainMenu"); 
			PlayerPrefs.SetInt("savedLevel", i);
		} else {
			Application.LoadLevel(i + 1);
		}
	}
}