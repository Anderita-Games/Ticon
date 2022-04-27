using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class BallControl : MonoBehaviour
{
    public int jumpHeight;
    public AudioClip Jump;
    private bool isFalling;
    public virtual void Update()
    {
        Time.timeScale = PlayerPrefs.GetInt("paused");
        if (Input.GetKeyDown(KeyCode.W) && (this.isFalling == false))
        {

            {
                int _1 = this.jumpHeight;
                Vector3 _2 = this.GetComponent<Rigidbody>().velocity;
                _2.y = _1;
                this.GetComponent<Rigidbody>().velocity = _2;
            }
            this.GetComponent<AudioSource>().PlayOneShot(this.Jump);
            this.isFalling = true;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space) && (this.isFalling == false))
            {

                {
                    int _3 = this.jumpHeight;
                    Vector3 _4 = this.GetComponent<Rigidbody>().velocity;
                    _4.y = _3;
                    this.GetComponent<Rigidbody>().velocity = _4;
                }
                this.GetComponent<AudioSource>().PlayOneShot(this.Jump);
                this.isFalling = true;
            }
        }
        //basic arrow key controls
        if (Input.GetKey("right"))
        {

            {
                int _5 = 2;
                Vector3 _6 = this.GetComponent<Rigidbody>().velocity;
                _6.x = _5;
                this.GetComponent<Rigidbody>().velocity = _6;
            }
        }
        else
        {
            if (Input.GetKey("left"))
            {

                {
                    int _7 = -2;
                    Vector3 _8 = this.GetComponent<Rigidbody>().velocity;
                    _8.x = _7;
                    this.GetComponent<Rigidbody>().velocity = _8;
                }
            }
        }
        if (Input.GetKey("up"))
        {

            {
                int _9 = 2;
                Vector3 _10 = this.GetComponent<Rigidbody>().velocity;
                _10.z = _9;
                this.GetComponent<Rigidbody>().velocity = _10;
            }
        }
        else
        {
            if (Input.GetKey("down"))
            {

                {
                    int _11 = -2;
                    Vector3 _12 = this.GetComponent<Rigidbody>().velocity;
                    _12.z = _11;
                    this.GetComponent<Rigidbody>().velocity = _12;
                }
            }
        }
        if (PlayerPrefs.GetInt("paused") == 1)
        {
            this.transform.Translate((Vector3.right * Input.acceleration.x) * 0.05f);
            this.transform.Translate((Vector3.forward * -Input.acceleration.z) * 0.05f);
        }
    }

    public virtual void OnCollisionStay()
    {
        this.isFalling = false;
    }

    public BallControl()
    {
        this.jumpHeight = 8;
    }

}