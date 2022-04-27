using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class GameMaster : MonoBehaviour
{
    public static int zero;
    public static int TextWidth;
    public static string savedLevel;
    public int i;
    public UnityEngine.UI.Text CTime;
    public UnityEngine.UI.Text HTime;
    public virtual void Start()
    {
        this.i = Application.loadedLevel;
        Debug.Log(Application.loadedLevelName);
        PlayerPrefs.SetInt("savedLevel", this.i);
        PlayerPrefs.SetInt("paused", 1);
        Time.timeScale = PlayerPrefs.GetInt("paused");
    }

    public virtual void Update()
    {
        //time text
        this.CTime.text = "Current Time: " + Time.timeSinceLevelLoad;
        if (GameMaster.zero >= PlayerPrefs.GetInt("Best" + Application.loadedLevelName))
        {
            this.HTime.text = "No best time!!!";
        }
        else
        {
            if (GameMaster.zero <= PlayerPrefs.GetInt("Best" + Application.loadedLevelName))
            {
                this.HTime.text = ("Best Time: " + PlayerPrefs.GetInt("Best" + Application.loadedLevelName)) + " seconds";
            }
        }
        Time.timeScale = PlayerPrefs.GetInt("paused"); // Set pause or naw
        if ((PlayerPrefs.GetInt("Endpoint") == 1) && (PlayerPrefs.GetInt("Endpoint2") == 1))
        {
            //reseting playerprefs
            PlayerPrefs.SetInt("Endpoint", 0);
            PlayerPrefs.SetInt("Endpoint2", 0);
            //setting new level continuation
            PlayerPrefs.SetInt("savedLevel", this.i + 1);
            if (Time.timeSinceLevelLoad <= PlayerPrefs.GetInt("Best" + Application.loadedLevelName))
            {
                PlayerPrefs.SetInt("Best" + Application.loadedLevelName, (int) Time.timeSinceLevelLoad);
            }
            else
            {
                //saving playerPrefs
                if (GameMaster.zero <= PlayerPrefs.GetInt("Best" + Application.loadedLevelName))
                {
                    PlayerPrefs.SetInt("Best" + Application.loadedLevelName, (int) Time.timeSinceLevelLoad);
                }
            }
            //saving playerPrefs
            if (((Application.loadedLevelName == "Level10") || (Application.loadedLevelName == "2Level10")) || (Application.loadedLevelName == "3Level10"))
            {
                Application.LoadLevel("MainMenu");
                PlayerPrefs.SetInt("savedLevel", this.i);
            }
            else
            {
                Application.LoadLevel(this.i + 1);
            }
        }
    }

    static GameMaster()
    {
        GameMaster.TextWidth = Screen.width / 4;
    }

}