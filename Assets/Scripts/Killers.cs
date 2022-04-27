using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class Killers : MonoBehaviour
{
    public virtual void Start()
    {
        Time.timeScale = PlayerPrefs.GetInt("paused");
    }

    public virtual void OnCollisionStay(Collision col)
    {
        if ((col.collider.name == "Sphere") || (col.collider.name == "Sphere #2"))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }

}