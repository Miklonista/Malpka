using System;
using System.Collections;
using System.ComponentModel;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

public class RangedEnemyController : EnemyControllerBase
{
    #region sfields

        [SerializeField] private float attackRange;
        [SerializeField] private float attackSpeed; 
        [SerializeField] private float attackTimer;
        [SerializeField] private GameObject bulletPrefab;
        [SerializeField] private Transform firePoint;
        
    #endregion

    #region fields

        private int counter = 0;
        private bool canShoot = false;

    #endregion
    

    private void Update()
    {
        if (attackTimer > 0f)
        {
            attackTimer -= Time.fixedDeltaTime;
            return;
        }
        if(canShoot) SpawnBullet();
    }
    
    protected override void FixedUpdate()
    {
        canShoot = false;
        if (Vector3.Distance(playerTransform.position, transform.position) > focusRange) return;
        MoveTowardsPlayer();
    }
        
    protected override void MoveTowardsPlayer()
    {
        var dir = Vector3.Normalize(playerTransform.position - transform.position);
        rb.velocity = movementSpeed * new Vector3(dir.x, rb.velocity.y, dir.z);
        if (Vector3.Distance(playerTransform.position, transform.position) > attackRange) return;
        canShoot = true;
        rb.velocity = Vector3.zero;
    }

    private void SpawnBullet()
    {
        Debug.Log("FIRE POINT POS: " + transform.position);
        attackTimer = 1.0f / attackSpeed;
        var bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        var b = firePoint;
        var c = playerTransform;
        StartCoroutine(bullet.GetComponent<RangedEnemyBullet>().Shoot(b.position, c.position));
    }
}
