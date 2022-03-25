using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManagers : MonoBehaviour
{
    //TODO: zmienic nazwe na MENU albo cos takiego 
    public void ChangeScene()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
