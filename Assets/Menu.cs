using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
 public void Exit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        Time.timeScale = 1f;


    }
}
