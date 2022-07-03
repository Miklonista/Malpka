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

    #endregion

    #region fields

    private int counter = 0;

    #endregion
    

    private void Update()
    {
        Debug.Log(attackTimer);
        if (attackTimer > 0f)
        {
            attackTimer -= Time.fixedDeltaTime;
        }
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }
                
    protected override void MoveTowardsPlayer()
    {
        var dir = Vector3.Normalize(playerTransform.position - transform.position);
        rb.velocity = movementSpeed * new Vector3(dir.x, rb.velocity.y, dir.z);
        if (Vector3.Distance(playerTransform.position, transform.position) > attackRange) return;
        rb.velocity = Vector3.zero;
        if (attackTimer > 0) return;
        SpawnBullet();
    }

    private void SpawnBullet()
    {
        counter++;
        attackTimer = 1.0f / attackSpeed;
        var targetPos = playerTransform.position;
        var dir = Vector3.Normalize(targetPos - transform.position);
        GameObject go = Instantiate(bulletPrefab);
        go.transform.position = transform.position;
        go.transform.rotation = transform.rotation;
        var bullet = go.AddComponent<RangedEnemyBullet>();
        StartCoroutine(bullet.Shoot(targetPos));
    }
}
