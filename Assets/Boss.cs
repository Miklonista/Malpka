using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

        if (hearts.Count != 0) return;
        Die();
    }

    private void RemoveHeart()
    {
        Debug.Log("here");
        hearts.RemoveAt(hearts.Count - 1);
    }
    
    private void Die()
    {
        Destroy(gameObject);
    }
}
