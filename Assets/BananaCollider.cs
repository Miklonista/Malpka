using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaCollider : Interactable
{
  protected override void OnTriggerEnter(Collider other)
  {
    if (!other.CompareTag("Enemy")) return;
    
    other.gameObject.GetComponent<HealthSystem>().TakeDamage(15);
  }
}
