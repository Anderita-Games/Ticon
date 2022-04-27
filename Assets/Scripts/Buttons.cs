using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class Buttons : MonoBehaviour
{
    public virtual void update()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    public virtual void QuitGame()
    {
        Debug.Log("Game is exiting...");
        Application.Quit();
    }

    public virtual void MainMenu()
    {
        Application.LoadLevel("MainMenu");
        Time.timeScale = 1;
    }

    public virtual void Playgame()
    {
        if (PlayerPrefs.HasKey("savedLevel"))
        {
            // there is a saved level, load that one
            Application.LoadLevel(PlayerPrefs.GetInt("savedLevel"));
        }
        else
        {
            // no saved level, load the first one
            Application.LoadLevel("Level1");
        }
    }

    public virtual void Tutorial()
    {
        Application.LoadLevel("Tutorial");
    }

    //All the scene selection stuff
    public virtual void LevelSelectoor()
    {
        Application.LoadLevel("LevelSelect");
    }

    public virtual void LevelS()
    {
        Application.LoadLevel("Level");
    }

    public virtual void LevelS2()
    {
        Application.LoadLevel("2Level");
    }

    public virtual void LevelS3()
    {
        Application.LoadLevel("3Level");
    }

    public virtual void Level1()
    {
        Application.LoadLevel("Level1");
    }

    public virtual void Level2()
    {
        Application.LoadLevel("Level2");
    }

    public virtual void Level3()
    {
        Application.LoadLevel("Level3");
    }

    public virtual void Level4()
    {
        Application.LoadLevel("Level4");
    }

    public virtual void Level5()
    {
        Application.LoadLevel("Level5");
    }

    public virtual void Level6()
    {
        Application.LoadLevel("Level6");
    }

    public virtual void Level7()
    {
        Application.LoadLevel("Level7");
    }

    public virtual void Level8()
    {
        Application.LoadLevel("Level8");
    }

    public virtual void Level9()
    {
        Application.LoadLevel("Level9");
    }

    public virtual void Level10()
    {
        Application.LoadLevel("Level10");
    }

    //Other level pack
    public virtual void L2evel1()
    {
        Application.LoadLevel("2Level1");
    }

    public virtual void L2evel2()
    {
        Application.LoadLevel("2Level2");
    }

    public virtual void L2evel3()
    {
        Application.LoadLevel("2Level3");
    }

    public virtual void L2evel4()
    {
        Application.LoadLevel("2Level4");
    }

    public virtual void L2evel5()
    {
        Application.LoadLevel("2Level5");
    }

    public virtual void L2evel6()
    {
        Application.LoadLevel("2Level6");
    }

    public virtual void L2evel7()
    {
        Application.LoadLevel("2Level7");
    }

    public virtual void L2evel8()
    {
        Application.LoadLevel("2Level8");
    }

    public virtual void L2evel9()
    {
        Application.LoadLevel("2Level9");
    }

    public virtual void L2evel10()
    {
        Application.LoadLevel("2Level10");
    }

    //Other level pack
    public virtual void L3evel1()
    {
        Application.LoadLevel("3Level1");
    }

    public virtual void L3evel2()
    {
        Application.LoadLevel("3Level2");
    }

    public virtual void L3evel3()
    {
        Application.LoadLevel("3Level3");
    }

    public virtual void L3evel4()
    {
        Application.LoadLevel("3Level4");
    }

    public virtual void L3evel5()
    {
        Application.LoadLevel("3Level5");
    }

    public virtual void L3evel6()
    {
        Application.LoadLevel("3Level6");
    }

    public virtual void L3evel7()
    {
        Application.LoadLevel("3Level7");
    }

    public virtual void L3evel8()
    {
        Application.LoadLevel("3Level8");
    }

    public virtual void L3evel9()
    {
        Application.LoadLevel("3Level9");
    }

    public virtual void L3evel10()
    {
        Application.LoadLevel("3Level10");
    }

}