using UnityEngine;

public class EnemyHeadCollision : Interactable
{
    protected override void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.tag);
        if (!collision.collider.CompareTag("PlayerFeet")) return;
        
        GameEvents.Instance.OnEnemyHeadHit();
    }
}
