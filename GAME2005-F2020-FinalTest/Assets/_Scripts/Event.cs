using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Event : MonoBehaviour
{    public void OnClickStart()
    {
        SceneManager.LoadScene("Main");
    }

    public void OnClickQuit()
    {
        Application.Quit();
    }

    public void OnClickMainMenu()
    {
        SceneManager.LoadScene("Start");
    }
}
