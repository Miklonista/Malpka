using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : Interactable
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<HPManager>())
        {
            collision.collider.SendMessage("TakeDamage", 20);
        }
    }
}
