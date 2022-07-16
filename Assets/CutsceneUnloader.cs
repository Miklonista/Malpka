using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneUnloader : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(WaitForSeconds());
    }

    IEnumerator WaitForSeconds()
    {
        yield return new WaitForEndOfFrame();
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(SceneNames.MENU_SCENE);
    }
}
