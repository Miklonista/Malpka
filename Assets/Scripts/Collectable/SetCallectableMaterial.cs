using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCallectableMaterial : MonoBehaviour
{
    public ItemSO Coin;
    private void Start()
    {
        gameObject.GetComponent<MeshRenderer>().material = Coin.coinMaterial;
    }
}
