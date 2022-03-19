using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Void : Interactable
{
    protected override void OnCollide()
    {
        GameManager.Instance.EnableDeathScreen();   
    }
}
