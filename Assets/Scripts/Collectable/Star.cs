using UnityEngine;


public class Star : Collectable
{
    protected override void OnTrigger()
    {
        PointsManager.Instance.StarPoints++;
        Destroy(gameObject);
    }
}
