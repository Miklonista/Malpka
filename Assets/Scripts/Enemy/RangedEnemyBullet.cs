using System;
using System.Collections;
using UnityEngine;

public class RangedEnemyBullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;
    
    private float error;
    private float startTime;
    
    private void Start()
    {
        startTime = Time.time;
        error = 0.05f;
    }

    public IEnumerator Shoot(Vector3 targetPos)
    {
        float distance = Vector3.Distance(targetPos, transform.position);
        float distCovered = 0f;
        float frac = 0f;
        Debug.Log(frac);
        while (Vector3.Distance(targetPos, transform.position) > error)
        {
            distCovered = (Time.time - startTime) * bulletSpeed;
            frac = distCovered / distance;

            transform.position = Vector3.Slerp(transform.position, targetPos, frac);
            transform.position += new Vector3(0, 0.01f, 0);
            yield return null;
        }

        Destroy(gameObject);
    }
}
