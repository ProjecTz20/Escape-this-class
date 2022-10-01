using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject Option;
    public GameObject Mainmenu;

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void quit()
    {
        Application.Quit();
        Debug.Log("quited");
    }

    public void OptionMenu()
    {
        if (GameIsPaused)
        {
            Resume();
        }

        else
        {
            {
                Pasue();
            }
        }

        void Resume()
        {
            Mainmenu.SetActive(true);
            Option.SetActive(false);
            GameIsPaused = false;
        }

        void Pasue()
        {
            Mainmenu.SetActive(false);
            Option.SetActive(true);
            GameIsPaused = true;
        }
    }
}
