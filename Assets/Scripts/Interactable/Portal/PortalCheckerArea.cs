using System;
using UnityEngine;

public class PortalCheckerArea : Interactable
{
    protected override void OnTrigger()
    {
        GameEvents.Instance.PlayerApproach();
    }
}
