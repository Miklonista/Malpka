using System;
using UnityEngine;

public class PortalEnter : Interactable
{
    [SerializeField] 
    private string sceneToLoad;

    private void OnEnable()
    {
        GameEvents.Instance.onTeleportTriggerEnter += TeleportPlayer;
    }
    private void OnDisable()
    {
        GameEvents.Instance.onTeleportTriggerEnter -= TeleportPlayer;
    }
    
    protected override void OnTrigger()
    {
        GameEvents.Instance.TeleportTriggerEnter();
    }
    private void TeleportPlayer()
    {
        GameManager.Instance.LoadScene(sceneToLoad);
    }
}