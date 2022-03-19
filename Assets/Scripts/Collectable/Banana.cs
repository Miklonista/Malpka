using UnityEngine;

public class Banana : Interactable
{
    public ItemSO bananaData;

    protected override void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        other.GetComponent<HealthSystem>().Heal(bananaData.points);
        Destroy(gameObject);
    }
}
