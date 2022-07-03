using System;
using System.Collections;
using UnityEngine;

public class RangedEnemyBullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;

    public static int ID;
    
    private float error;
    private float startTime;
    private float distCovered = 0f;
    private float frac = 0f;
    private float dist = 0;

    private void Start()
    {
        ID++;
        startTime = Time.time;
        error = 0.5f;
    }

    public IEnumerator Shoot(Vector3 firePoint, Vector3 targetPos)
    {
        Debug.Log(ID);
        dist = Vector3.Distance(firePoint, targetPos);
        Debug.Log("BULLET SPAWN POS: " + transform.position);
        while (Vector3.Distance(transform.position, targetPos) > error)
        {
            distCovered = (Time.time - startTime) * bulletSpeed;
            frac = distCovered / dist;
            transform.position = Vector3.Slerp(firePoint, targetPos, frac);
            transform.position += new Vector3(0, 0.01f, 0);
           // yield return new WaitForSeconds(1f);
           yield return null;
        }

        Destroy(gameObject);
    }
}
