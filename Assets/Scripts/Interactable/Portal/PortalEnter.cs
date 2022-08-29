using System;
using UnityEngine;

public class PortalEnter : Interactable
{
    [SerializeField] 
    private string sceneToLoad;
    protected override void OnTrigger()
    {
        TeleportPlayer();
    }
    private void TeleportPlayer()
    {
        GameManager.Instance.LoadScene(sceneToLoad);
    }
}