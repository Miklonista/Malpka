using System.Security.Cryptography;
using UnityEngine;

public class BossHeartHealth : HealthSystem
{
    protected override void Die()
    { 
        GameEvents.Instance.HeartDestroyed(); 
        Destroy(gameObject);
    }
}
