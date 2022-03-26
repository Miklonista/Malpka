using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
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
        GameEvents.Instance.onEnemyHeadTriggerEnter += OnEnemyStunned;
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

    private void OnEnemyStunned()
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
    }
}