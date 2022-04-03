using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Coin : Interactable
{
    public ItemSO coinData;

    protected override void OnTrigger()
    {
        PointsManager.Instance.Points += coinData.points;
        //SoundManager.PlaySound();
        Destroy(gameObject);
    }
}

