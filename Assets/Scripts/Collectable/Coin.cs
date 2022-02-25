using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public ItemSO coin;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PointsManager.Instance.AddPoint(coin);
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("Zebra³ to, zebra³");
        }
    }
}

