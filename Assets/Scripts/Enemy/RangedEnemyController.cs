using System.Collections;
using UnityEngine;

public class RangedEnemyController : EnemyControllerBase
{
    [SerializeField] private float attackRange;
    [SerializeField] private float attackSpeed;
    [SerializeField] private GameObject bulletPrefab;

    private bool canShoot = true;
    
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
        if (!canShoot) return;
        StartCoroutine(PerformAttack());
    }

    private IEnumerator PerformAttack()
    {
        var targetPos = playerTransform.position;
        var dir = Vector3.Normalize(targetPos - transform.position);
        canShoot = false;
        GameObject go = Instantiate(bulletPrefab);
        go.transform.position = transform.position;
        go.transform.rotation = transform.rotation;

        yield return null;
    }
}
