using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour 
{
    public static GameManager Instance;
    
    [SerializeField]
    private Canvas deathScreen;
    
    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void EnableDeathScreen()
    {
        deathScreen.gameObject.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0;
    }

    public void LoadNewScene(string sceneName)
    {
       SceneManager.LoadScene(sceneName);
    }
}

