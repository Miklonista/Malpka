using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{  
    public float lookRadius = 30f;
    private Animator animator;
    Transform target;// czy player jest w terenie
    NavMeshAgent agent;
    
    void Start()
    {
         animator = GetComponent<Animator>();
        target = GameObject.Find("Player").transform;
        agent = GetComponent<NavMeshAgent>();

    }
    
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        

        if (distance <= lookRadius)
        {
            agent.SetDestination(target.position);
            animator.SetBool("Aware", true);

            if(distance <= agent.stoppingDistance)
            {
               FaceTarget();
            }

        }
        else
        {
            
            animator.SetBool("Aware", false);
        }
        void FaceTarget()// obracanie sie na przeciwnika
        {
            Vector3 direction = (target.position - transform.position);
            Quaternion LookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
            transform.rotation = LookRotation;
        }

    }
    void OnDrawGizmosSelected()//Czerwona obr�cz
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
