using System;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [SerializeField] private GameObject bananaWeapon;

    private bool isAbleToFire = true;
    private void Update()
    {
        if (!isAbleToFire) return;

        if (Input.GetKey(KeyCode.Q))
        {
            Throw();
        }
    }

    private void Throw()
    {
        //tu bedzie DOTween
        //bananaWeapon.transform.position = Vector3.Lerp(transform.forward, Vector3*(transform.position * transform.forward) * 10f, 1);
    }
}
