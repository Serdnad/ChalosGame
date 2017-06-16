using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    public Canvas mainmenu;
    public Canvas levelselect;

    void Awake()
    {
        levelselect.enabled = false;
    }

    public void levelselectOn()
    {
        mainmenu.enabled = false;
        levelselect.enabled = true;
    }

    public void levelselectBack()
    {
        mainmenu.enabled = true;
        levelselect.enabled = false;
    }

    public void quit()
    {
        Application.Quit();
    }

    public void level1()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void level2()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Single);
    }

    public void level3()
    {
        SceneManager.LoadScene(3, LoadSceneMode.Single);
    }
}
