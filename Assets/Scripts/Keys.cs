using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class Keys : MonoBehaviour
{
    public GameObject BlockLock;
    public bool boi;
    public virtual void Start()
    {
        Time.timeScale = PlayerPrefs.GetInt("paused");
    }

    public virtual void OnCollisionEnter(Collision col)
    {
        if (((col.collider.name == "Sphere") || (col.collider.name == "Sphere #2")) && (this.boi == false))
        {
            this.BlockLock.SetActive(false);
            this.boi = true;
        }
        else
        {
            if (((col.collider.name == "Sphere") || (col.collider.name == "Sphere #2")) && (this.boi == true))
            {
                this.BlockLock.SetActive(true);
                this.boi = false;
            }
        }
    }

}