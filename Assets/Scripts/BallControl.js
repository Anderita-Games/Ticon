#pragma strict
var jumpHeight = 8;
var Jump:AudioClip;
private var isFalling = false;

function Update () {
	
	Time.timeScale = PlayerPrefs.GetInt("paused");
	
	if (Input.GetKeyDown (KeyCode.W) && isFalling == false){
		GetComponent.<Rigidbody>().velocity.y = jumpHeight;
		GetComponent.<AudioSource>().PlayOneShot(Jump);
		isFalling = true;
	}else if (Input.GetKeyDown (KeyCode.Space) && isFalling == false){
		GetComponent.<Rigidbody>().velocity.y = jumpHeight;
		GetComponent.<AudioSource>().PlayOneShot(Jump);
		isFalling = true;
	}
	
	//basic arrow key controls
	if (Input.GetKey ("right")){
		GetComponent.<Rigidbody>().velocity.x = 2;
	}else if (Input.GetKey ("left")){
		GetComponent.<Rigidbody>().velocity.x = -2;
	}
	if (Input.GetKey ("up")){
		GetComponent.<Rigidbody>().velocity.z = 2;
	}else if (Input.GetKey ("down")){
		GetComponent.<Rigidbody>().velocity.z = -2;
	}
	
	if (PlayerPrefs.GetInt("paused") == 1) {
		transform.Translate(Vector3.right * Input.acceleration.x * .05);
		transform.Translate(Vector3.forward * -Input.acceleration.z * .05);
	}
}

function OnCollisionStay (){
	isFalling = false;
}
