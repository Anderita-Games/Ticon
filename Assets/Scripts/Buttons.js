#pragma strict

function update () {
	Screen.sleepTimeout = SleepTimeout.NeverSleep;
}

function QuitGame ()  {
	Debug.Log ("Game is exiting...");
	Application.Quit ();
}

function MainMenu() {
	Application.LoadLevel("MainMenu");
	Time.timeScale = 1;
}

function Playgame() {
	if(PlayerPrefs.HasKey("savedLevel")){
   		// there is a saved level, load that one
   		Application.LoadLevel(PlayerPrefs.GetInt("savedLevel"));
	} else{
   		// no saved level, load the first one
   		Application.LoadLevel("Level1");
 	}
}

function Tutorial() {
	Application.LoadLevel("Tutorial");
}

//All the scene selection stuff
function LevelSelectoor() {
	Application.LoadLevel("LevelSelect");
}
function LevelS() {
	Application.LoadLevel("Level");
}
function LevelS2() {
	Application.LoadLevel("2Level");
}
function LevelS3() {
	Application.LoadLevel("3Level");
}
function Level1() {
	Application.LoadLevel("Level1");
}
function Level2() {
	Application.LoadLevel("Level2");
}
function Level3() {
	Application.LoadLevel("Level3");
}
function Level4() {
	Application.LoadLevel("Level4");
}
function Level5() {
	Application.LoadLevel("Level5");
}
function Level6() {
	Application.LoadLevel("Level6");
}
function Level7() {
	Application.LoadLevel("Level7");
}
function Level8() {
	Application.LoadLevel("Level8");
}
function Level9() {
	Application.LoadLevel("Level9");
}
function Level10() {
	Application.LoadLevel("Level10");
}
//Other level pack
function L2evel1() {
	Application.LoadLevel("2Level1");
}
function L2evel2() {
	Application.LoadLevel("2Level2");
}
function L2evel3() {
	Application.LoadLevel("2Level3");
}
function L2evel4() {
	Application.LoadLevel("2Level4");
}
function L2evel5() {
	Application.LoadLevel("2Level5");
}
function L2evel6() {
	Application.LoadLevel("2Level6");
}
function L2evel7() {
	Application.LoadLevel("2Level7");
}
function L2evel8() {
	Application.LoadLevel("2Level8");
}
function L2evel9() {
	Application.LoadLevel("2Level9");
}
function L2evel10() {
	Application.LoadLevel("2Level10");
}
//Other level pack
function L3evel1() {
	Application.LoadLevel("3Level1");
}
function L3evel2() {
	Application.LoadLevel("3Level2");
}
function L3evel3() {
	Application.LoadLevel("3Level3");
}
function L3evel4() {
	Application.LoadLevel("3Level4");
}
function L3evel5() {
	Application.LoadLevel("3Level5");
}
function L3evel6() {
	Application.LoadLevel("3Level6");
}
function L3evel7() {
	Application.LoadLevel("3Level7");
}
function L3evel8() {
	Application.LoadLevel("3Level8");
}
function L3evel9() {
	Application.LoadLevel("3Level9");
}
function L3evel10() {
	Application.LoadLevel("3Level10");
}


