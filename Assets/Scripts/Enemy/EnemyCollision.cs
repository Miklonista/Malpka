using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : Interactable
{
   protected override void OnCollisionEnter(Collision collision)
   { 
       if (!collision.collider.CompareTag("Player")) return;
     collision.collider.GetComponent<HealthSystem>().TakeDamage(20);
   }
}
