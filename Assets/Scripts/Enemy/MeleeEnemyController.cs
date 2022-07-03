using UnityEngine;

    public class MeleeEnemyController : EnemyControllerBase
    {
        protected override void MoveTowardsPlayer()
        {
            var dir = movementSpeed * Vector3.Normalize(playerTransform.position - transform.position);
            rb.velocity = new Vector3(dir.x, rb.velocity.y, dir.z);
            if (rb.velocity.magnitude >= 0.1f)
            {
                animator.SetBool("run", true);
            }
            else
            {
                animator.SetBool("run", false);
            }
        }
    }
