using System.Security.Cryptography;
using UnityEngine;

public class EnemyHealth : HealthSystem
{
    protected override void Die()
    {
        animator.SetBool("dead", true );
        Destroy(gameObject);
    }
}
