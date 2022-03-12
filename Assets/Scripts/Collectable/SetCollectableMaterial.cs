using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class SetCollectableMaterial : MonoBehaviour
{
    public ItemSO coinData;
    private void Start() => gameObject.GetComponent<MeshRenderer>().material = coinData.coinMaterial;
    
}
