using System;
using UnityEngine;

public class PortalEnter : Interactable
{
    [SerializeField] 
    private string sceneToLoad;

    private void Start()
    {
        GameEvents.Instance.onTeleportTriggerEnter += TeleportPlayer;
    }
    private void OnDestroy()
    {
        GameEvents.Instance.onTeleportTriggerEnter -= TeleportPlayer;
    }
    
    protected override void OnTrigger()
    {
        GameEvents.Instance.TeleportTriggerEnter();
    }
    private void TeleportPlayer()
    {
        GameManager.Instance.LoadNewScene(sceneToLoad);
    }
}