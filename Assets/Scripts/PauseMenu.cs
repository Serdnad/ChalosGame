using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {
    public Transform pausemenu;
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausemenu.gameObject.activeInHierarchy == false)
            {
                pausemenu.gameObject.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                pausemenu.gameObject.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }

        public void resume()
    {
        pausemenu.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

        public void backtomenu()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
        Time.timeScale = 1;
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
        Time.timeScale = 1;
    }

    }
