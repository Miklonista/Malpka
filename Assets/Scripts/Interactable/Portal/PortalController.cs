using System;
using UnityEngine;
using UnityEngine.Serialization;

public class PortalController : MonoBehaviour
{
    [SerializeField]
    private int starsToUnlock;

    [SerializeField] 
    private GameObject portalArea;

    private void OnEnable()
    {
        GameEvents.Instance.onPlayerApproach += CheckStarPoints;
    }

    private void OnDisable()
    {
        GameEvents.Instance.onPlayerApproach -= CheckStarPoints;
    }

    private void CheckStarPoints()
    {
        Debug.Log("CheckStarPoints");
        if (PointsManager.Instance.StarPoints < starsToUnlock) return;
        if(!portalArea.activeSelf) portalArea.SetActive(true);
    }
}

