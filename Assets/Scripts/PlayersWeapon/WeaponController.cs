using System;
using System.Threading.Tasks;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [SerializeField] 
    private GameObject bananaWeapon;
    [SerializeField] 
    private float speedMultiplier;
    [SerializeField]
    private float flightTime;
    
    private bool canShoot = true;
    private float currentFlightTimer = 0f;
    
    private async void Update()
    {
        if (!canShoot) return;
        if (Input.GetKeyDown(KeyCode.Q))
        {
            bananaWeapon.SetActive(true);
            currentFlightTimer = flightTime;
            canShoot = false;
            await Throw();
            if (Throw().IsCompleted)
            {
               await Comeback(); 
            }
        }
    }

    private void FixedUpdate()
    {
        if (currentFlightTimer > 0)
        {
            currentFlightTimer -= Time.fixedDeltaTime;
        }
    }

    private async Task Throw()
    {
        var dir = transform.forward;
        while (currentFlightTimer > 0)
        {
            bananaWeapon.transform.Translate(speedMultiplier * dir, Space.World);
            await Task.Yield();
        }
    }

    private async Task Comeback()
    {
        currentFlightTimer = flightTime;
        while (currentFlightTimer > 0)
        {
            var dir = (transform.position - bananaWeapon.transform.position).normalized;
            bananaWeapon.transform.Translate(speedMultiplier * dir, Space.World);
            await Task.Yield();
        }
        bananaWeapon.SetActive(false);
        canShoot = true;
    }
}
