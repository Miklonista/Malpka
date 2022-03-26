using UnityEngine;

public class DeathScreen : MonoBehaviour
{
    public void PlayAgain()
    {
        GameManager.Instance.LoadScene(SceneNames.FIRST_SCENE);
    }
    public void QuitToMenu()
    {
        GameManager.Instance.LoadScene(SceneNames.MENU_SCENE);
    }
}