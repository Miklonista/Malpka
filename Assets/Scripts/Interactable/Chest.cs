using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = System.Random;

public class Chest : Interactable
{
    [SerializeField] private ItemListSO itemList;
    
    private Random random = new Random();

   protected override void OnTrigger()
    {
        spawnItem();
        Destroy(gameObject);
        
    }

    private void spawnItem()
    {
        var id = random.Next(itemList.itemList.Count);
        Debug.Log(itemList.itemList[id].name);
        Instantiate(itemList.itemList[id],transform.position,quaternion.identity);
    }
}


   