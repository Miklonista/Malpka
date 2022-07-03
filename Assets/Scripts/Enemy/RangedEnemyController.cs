using UnityEngine;

public class RangedEnemyController : EnemyControllerBase
{
    [SerializeField] private float attackRange;

    private bool canShoot = true;
    
    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }
                
    protected override void MoveTowardsPlayer()
    {
        var dir = movementSpeed * Vector3.Normalize(playerTransform.position - transform.position);
        rb.velocity = new Vector3(dir.x, rb.velocity.y, dir.z);
        if (Vector3.Distance(playerTransform.position, transform.position) > attackRange) return;
        rb.velocity = Vector3.zero;
    }
}
