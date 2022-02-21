using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public ItemSO coin;
    private int coinValue = 0;
    private void Start()
    {
        coinValue = coin.points;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PointsManager.Instance.AddPoint(coinValue);
            GameManager.Instance.test();
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("Zebra³ to, zebra³");
        }
    }
        
}

