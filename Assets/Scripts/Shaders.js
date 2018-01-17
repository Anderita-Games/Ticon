#pragma strict

function Start () {
	PlayerPrefs.SetInt("Endpoint", 0);
	PlayerPrefs.SetInt("Endpoint2", 0);
	PlayerPrefs.SetString("Banned", "");
	PlayerPrefs.SetString("Banned2", "");
	Time.timeScale = PlayerPrefs.GetInt("paused");
}

function OnCollisionStay(col : Collision) {
	
	if (gameObject.name == "Endpoint") {
		if (col.collider.name != PlayerPrefs.GetString("Banned2") && PlayerPrefs.GetInt(gameObject.name) == 0) {
			PlayerPrefs.SetString("Banned", col.collider.name);
			PlayerPrefs.SetInt(gameObject.name, 1);
		}
	} else if (gameObject.name == "Endpoint2") {
		if (col.collider.name != PlayerPrefs.GetString("Banned") && PlayerPrefs.GetInt(gameObject.name) == 0) {
			PlayerPrefs.SetString("Banned2", col.collider.name);
			PlayerPrefs.SetInt(gameObject.name, 1);
		}
	}
}

function OnCollisionExit(col : Collision) {
	if (gameObject.name == "Endpoint") {
		if (col.collider.name == PlayerPrefs.GetString("Banned") && PlayerPrefs.GetInt("Endpoint") == 1) {
			PlayerPrefs.SetInt(gameObject.name, 0);
		}
	}else if (gameObject.name == "Endpoint2") {
		if (col.collider.name == PlayerPrefs.GetString("Banned2") && PlayerPrefs.GetInt("Endpoint2") == 1) {
			PlayerPrefs.SetInt(gameObject.name, 0);
		}
	}
}
	