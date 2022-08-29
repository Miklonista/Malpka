using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Boss : MonoBehaviour
{
    [SerializeField] private List<GameObject> hearts = new List<GameObject>();

    private void OnEnable()
    {
        GameEvents.Instance.onHeartDestroyed += RemoveHeart;
    }
    private void OnDisable()
    {
        GameEvents.Instance.onHeartDestroyed -= RemoveHeart;
    }

    private void Update()
    {
        if((int)Time.time % 4 == 0) SpawnMob();
        if (hearts.Count != 0) return;
        Die();
    }

    private void RemoveHeart()
    {
        Debug.Log("here");
        hearts.RemoveAt(hearts.Count - 1);
    }

    private void SpawnMob()
    {
        int result = Random.Range(0, 2); // 0 - melee, 1 - ranged

        if (result > 1) return;

        Action spawnMelee = () =>
        {
            
        };
        Action spawnRanged = () =>
        {
            
        };

        var func = result == 0 ? spawnMelee : spawnRanged;
        func(); // just testing ternary operator and lambda possibilities, its sick but shit
    }
    
    private void Die()
    {
        // add a reward 
        Destroy(gameObject);
    }
}
