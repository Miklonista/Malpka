﻿using System;
using UnityEngine;

public class PlayerJumpAttack : MonoBehaviour
{
    [SerializeField] 
    private Rigidbody rb;
    /// <summary>
    /// Force value applied in a vertical direction to a player after jumping on enemy's head
    /// </summary>
    [SerializeField] 
    private float bounceForce = 500f;

    private void OnEnable()
    {
        GameEvents.Instance.onEnemyHeadHitEnter += BounceOff;
    }

    private void OnDisable()
    {
        GameEvents.Instance.onEnemyHeadHitEnter -= BounceOff;
    }

    public void BounceOff()
    {
        rb.AddForce(new Vector3(0, bounceForce, 0), ForceMode.Impulse);
    }
}
