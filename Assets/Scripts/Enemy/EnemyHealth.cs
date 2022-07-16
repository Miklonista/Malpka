using System;
using System.Security.Cryptography;
using UnityEngine;

public class EnemyHealth : HealthSystem
{
    protected override void Start()
    {
        maxHP = 30;
        base.Start();
    }

    protected override void Die()
    {
        animator.SetBool("dead", true );
        Destroy(gameObject);
    }
}
