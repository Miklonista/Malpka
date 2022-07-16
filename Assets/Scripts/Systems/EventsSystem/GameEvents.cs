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
    public event Action onHeartDestroyed;

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
            onTeleportTriggerEnter?.Invoke();
        }
    
        public void PlayerApproach()
        {
            onPlayerApproach?.Invoke();
        }

    #endregion

    public void InstantiateBullet()
    {
        onPlayerInRange?.Invoke();
    }

    public void HeartDestroyed()
    {
        Debug.Log("HeartDestroyed()");
        onHeartDestroyed?.Invoke();
    }
}
