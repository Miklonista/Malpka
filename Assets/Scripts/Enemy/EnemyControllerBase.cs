using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public abstract class EnemyControllerBase : MonoBehaviour
{
    #region old version

    /*[SerializeField]
        private float lookRadius = 30f;
    
        [SerializeField]
        private float speed = 12f;
        
        private Animator animator;
        private Transform target; // czy player jest w terenie
        private NavMeshAgent agent;
        
        private void Start()
        {
            animator = GetComponent<Animator>();
            target = GameObject.Find("Player").transform;
            agent = GetComponent<NavMeshAgent>();
            agent.speed = speed;
        }
        
        private void Update()
        {
            var distance = Vector3.Distance(target.position, transform.position);
    
    
            if (distance <= lookRadius)
            {
                agent.SetDestination(target.position);
                animator.SetBool("Aware", true);
    
                if (distance <= agent.stoppingDistance) FaceTarget();
            }
            else
            {
                animator.SetBool("Aware", false);
            }
    
            void FaceTarget() // obracanie sie na przeciwnika
            {
                var direction = target.position - transform.position;
                var LookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
                transform.rotation = LookRotation;
            }
        }
    
        private void StunEnemy()
        {
            StartCoroutine(Stun());
        }
    
        IEnumerator Stun()
        {
            agent.speed = 0f;
            animator.SetBool("Aware", false);
            yield return new WaitForSeconds(2f);
            agent.speed = this.speed;
            animator.SetBool("Aware", true);
        }
        private void OnDrawGizmosSelected() //Czerwona obr�cz
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, lookRadius);
        }*/

    #endregion

    [SerializeField] 
    protected Transform playerTransform;
    [SerializeField] 
    private EnemyStatsSO enemyData;
    
    protected Animator animator;
    
    
    protected float focusRange;
    protected float movementSpeed;
    private readonly float turnSmoothTime = 0.1f;
    private float turnSmoothVelocity;
    
    protected Rigidbody rb;

    protected virtual void Start()
    {
        rb = GetComponent<Rigidbody>();
        movementSpeed = enemyData.movementSpeed;
        focusRange = enemyData.attackRange;
        animator = GetComponent<Animator>();
    }
    
    protected virtual void FixedUpdate()
    {
        if (Vector3.Distance(playerTransform.position, transform.position) > focusRange) return;

        LookAtPlayer();
        MoveTowardsPlayer();
    }

    private void LookAtPlayer()
    {
        var dir = (playerTransform.position - transform.position).normalized;
        var targetAngle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg;
        var angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
        transform.rotation = Quaternion.Euler(0f, angle, 0f);
    }
    protected abstract void MoveTowardsPlayer();
}