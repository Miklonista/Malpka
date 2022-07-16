using System;
using UnityEngine;


public class GameEvents : MonoBehaviour
{
    public static GameEvents Instance;

    #region Event Actions

    public event Action onTeleportTriggerEnter;
    public event Action onPlayerApproach;
    /// <summary>
    /// Event that's beeing invoked when player gets into shooting enemy's range
    /// </summary>
    public event Action onPlayerInRange;

    #endregion
    
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else Instance = this;
    }

    #region teleport methods

        public void TeleportTriggerEnter()
        {
            Debug.Log("TeleportTriggerEnter");
            onTeleportTriggerEnter?.Invoke();
        }
    
        public void PlayerApproach()
        {
            Debug.Log("PlayerApproach");
            onPlayerApproach?.Invoke();
        }

    #endregion

    public void InstantiateBullet()
    {
        Debug.Log("InstantiateBullet");
        onPlayerInRange?.Invoke();
    }
}
