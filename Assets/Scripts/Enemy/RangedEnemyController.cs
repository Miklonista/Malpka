using System;
using System.Collections;
using System.ComponentModel;
using Unity.Collections;
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

    #endregion
    

    private void Update()
    {
        if (attackTimer > 0f)
        {
            attackTimer -= Time.fixedDeltaTime;
            return;
        }
        SpawnBullet();
    }
        
    protected override void MoveTowardsPlayer()
    {
        var dir = Vector3.Normalize(playerTransform.position - transform.position);
        rb.velocity = movementSpeed * new Vector3(dir.x, rb.velocity.y, dir.z);
        if (Vector3.Distance(playerTransform.position, transform.position) > attackRange) return;
        rb.velocity = Vector3.zero;
    }

    private void SpawnBullet()
    {
        counter++;
        attackTimer = 1.0f / attackSpeed;
        var targetPos = playerTransform.position;
        var go = Instantiate(bulletPrefab);
        go.transform.position = firePoint.position;
        go.transform.rotation = firePoint.rotation;
        Debug.Log(go.transform.position);
        StartCoroutine(go.GetComponent<RangedEnemyBullet>().Shoot(targetPos));
    }
}
