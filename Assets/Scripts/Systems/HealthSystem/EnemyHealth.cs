using System.Security.Cryptography;
using UnityEngine;

public class EnemyHealth : HealthSystem
{
    protected override void Die()
    {
        Destroy(gameObject);
    }
}
