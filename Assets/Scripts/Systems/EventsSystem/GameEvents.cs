using System;
using UnityEngine;


public class GameEvents : MonoBehaviour
{
    public static GameEvents Instance;

    #region Event Actions

    public event Action onTeleportTriggerEnter;
    public event Action onPlayerApproach;
    public event Action onEnemyHeadHitEnter;

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

    public void OnEnemyHeadHit()
    {
        Debug.Log("EnemyHeadTriggerEnter");
        onEnemyHeadHitEnter?.Invoke();
    }
}
