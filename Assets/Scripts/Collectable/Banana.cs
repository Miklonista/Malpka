using UnityEngine;

public class Banana : Interactable
{
    public ItemSO bananaData;

    protected override void OnTrigger()
    {
        //TODO: stworzyc system HP i zrobic zeby ten banan dzialal
        Destroy(gameObject);
    }
}
