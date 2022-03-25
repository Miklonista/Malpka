using UnityEngine;


public class Star : Interactable
{
    protected override void OnTrigger()
    {
        PointsManager.Instance.StarPoints++;
        Destroy(gameObject);
    }
}
