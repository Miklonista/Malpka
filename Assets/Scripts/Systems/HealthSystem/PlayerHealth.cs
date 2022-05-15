using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : HealthSystem
{
    protected override void Die()
    {
        Debug.Log("œmieræ");
        GameManager.Instance.EnableDeathScreen();
    }
}
