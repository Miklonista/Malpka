using UnityEngine;

public class EnemyHeadCollision : Interactable
{
    protected override void OnTriggerEnter(Collider other)
    {
        if(!other.CompareTag("PlayerFeet")) return;
        GameEvents.Instance.EnemyHeadTriggerEnter();
    }

}
