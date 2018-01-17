#pragma strict
public var BlockLock : GameObject;
var boi = false;

function Start () {
	Time.timeScale = PlayerPrefs.GetInt("paused");
}

function OnCollisionEnter(col : Collision) {
	
	if ((col.collider.name == "Sphere" || col.collider.name == "Sphere #2") && boi == false) {
		BlockLock.SetActive (false);
		boi = true;
	}else if ((col.collider.name == "Sphere" || col.collider.name == "Sphere #2") && boi == true) {
		BlockLock.SetActive (true);
		boi = false;
	}
}