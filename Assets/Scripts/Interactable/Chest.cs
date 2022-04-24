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
    private ParticleSystem explosionParticle;

    private void Start()
    {
        explosionParticle = transform.parent.GetComponentInChildren<ParticleSystem>();

    }

    protected override void OnTrigger()
    {
        explosionParticle.Play();
        spawnItem();
        Destroy(gameObject);
    } 
    /*protected override void OnCollisionEnter(Collision collision)
    {
        explosionParticle.Play();
    }*/
    private void spawnItem()
    {
        var id = random.Next(itemList.itemList.Count);
        Debug.Log(itemList.itemList[id].name);
        Instantiate(itemList.itemList[id],transform.position,quaternion.identity);
    }
}


   