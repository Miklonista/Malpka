using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreen : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    
    
    private bool isActive = false;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            ChangePanelStatusPanel();
        }
    }

    private void ChangePanelStatusPanel()
    {
        isActive = !isActive;
        panel.SetActive(isActive);
        Time.timeScale = isActive ? 0f : 1f;
        Cursor.lockState = isActive ? CursorLockMode.None : CursorLockMode.Locked;
    }

    public void Continue()
    {
        Time.timeScale = 1f;
        isActive = !isActive;
        Cursor.lockState = CursorLockMode.Locked;
        panel.SetActive(isActive);
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Jungle Level");
    }

    public void QuitToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
