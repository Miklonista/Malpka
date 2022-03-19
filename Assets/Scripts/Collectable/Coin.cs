using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Interactable
{
    public ItemSO coinData;

    protected override void OnTrigger()
    {
        PointsManager.Instance.Points += coinData.points;
        Destroy(gameObject);
    }
}

