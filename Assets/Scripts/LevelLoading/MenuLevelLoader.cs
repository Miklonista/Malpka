using UnityEngine;

    public class MenuLevelLoader : LevelLoader
    {
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void QuitGame()
        {
            Application.Quit();
        }
    }
