using System;
using System.Collections;
using UnityEngine;

public class RangedEnemyBullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Transform firePointTransform;
    
    private float error = 0.5f;
    private float startTime;
    private float distCovered = 0f;
    private float frac = 0f;
    private float dist = 0;
    
    public bool IsSent
    {
        get;
        private set;
    }
    

    private void OnEnable()
    {
        GameEvents.Instance.onPlayerInRange += Instantiate;
        Debug.Log("onPlayerInRange += Instantiate");
    }

    private void OnDisable()
    {
        GameEvents.Instance.onPlayerInRange -= Instantiate;
    }

    private void Start()
    {
        firePointTransform = GetComponentInParent<Transform>();
        startTime = Time.time;
    }

    private void Instantiate()
    {
        IsSent = true;
        startTime = Time.time;
        StartCoroutine(Shoot());
    }
    
    private IEnumerator Shoot()
    {
        var playerPos = playerTransform.position;
        dist = Vector3.Distance(transform.position, playerPos);
        Debug.Log(dist);
        while (Vector3.Distance(transform.position, playerPos) > error)
        {
            distCovered = (Time.time - startTime) * bulletSpeed;
            frac = distCovered / dist;
            transform.position = Vector3.Slerp(transform.position, playerPos, frac);
            transform.position += new Vector3(0f, 0.01f, 0f);
            yield return null;
        }
        
        gameObject.SetActive(false);
        gameObject.transform.localPosition = Vector3.zero;
        IsSent = false;
    }
}
