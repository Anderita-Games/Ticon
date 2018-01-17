#pragma strict

function Start () {
	Time.timeScale = PlayerPrefs.GetInt("paused");
}

function OnCollisionStay(col : Collision) {
	
	if (col.collider.name == "Sphere" || col.collider.name == "Sphere #2") {
		Application.LoadLevel(Application.loadedLevel);
	}
}