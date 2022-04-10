using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Interactable
{
    protected override void OnTrigger()
    {
        
        Destroy(gameObject);
    }
}
   