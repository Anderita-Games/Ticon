using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class Shaders : MonoBehaviour
{
    public virtual void Start()
    {
        PlayerPrefs.SetInt("Endpoint", 0);
        PlayerPrefs.SetInt("Endpoint2", 0);
        PlayerPrefs.SetString("Banned", "");
        PlayerPrefs.SetString("Banned2", "");
        Time.timeScale = PlayerPrefs.GetInt("paused");
    }

    public virtual void OnCollisionStay(Collision col)
    {
        if (this.gameObject.name == "Endpoint")
        {
            if ((col.collider.name != PlayerPrefs.GetString("Banned2")) && (PlayerPrefs.GetInt(this.gameObject.name) == 0))
            {
                PlayerPrefs.SetString("Banned", col.collider.name);
                PlayerPrefs.SetInt(this.gameObject.name, 1);
            }
        }
        else
        {
            if (this.gameObject.name == "Endpoint2")
            {
                if ((col.collider.name != PlayerPrefs.GetString("Banned")) && (PlayerPrefs.GetInt(this.gameObject.name) == 0))
                {
                    PlayerPrefs.SetString("Banned2", col.collider.name);
                    PlayerPrefs.SetInt(this.gameObject.name, 1);
                }
            }
        }
    }

    public virtual void OnCollisionExit(Collision col)
    {
        if (this.gameObject.name == "Endpoint")
        {
            if ((col.collider.name == PlayerPrefs.GetString("Banned")) && (PlayerPrefs.GetInt("Endpoint") == 1))
            {
                PlayerPrefs.SetInt(this.gameObject.name, 0);
            }
        }
        else
        {
            if (this.gameObject.name == "Endpoint2")
            {
                if ((col.collider.name == PlayerPrefs.GetString("Banned2")) && (PlayerPrefs.GetInt("Endpoint2") == 1))
                {
                    PlayerPrefs.SetInt(this.gameObject.name, 0);
                }
            }
        }
    }

}