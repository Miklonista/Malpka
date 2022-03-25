using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void LoadFirstLevel()
    {
        SceneManager.LoadScene(SceneNames.FIRST_SCENE);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
