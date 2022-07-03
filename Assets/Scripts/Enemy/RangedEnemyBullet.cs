using System;
using System.Collections;
using UnityEngine;

public class RangedEnemyBullet : MonoBehaviour
{
    private float error;

    private void Start()
    {
        error = 0.5f;
    }

    public IEnumerator Shoot(Vector3 targetPos)
    {
        float distance = Vector3.Distance(targetPos, transform.position);
        
        Debug.Log("[INFO] Shoot");
        yield return null;
    }
}
