using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCollectableMaterial : MonoBehaviour
{
    public ItemSO coin;
    private void Start()
    {
        gameObject.GetComponent<MeshRenderer>().material = coin.coinMaterial;
    }
}
