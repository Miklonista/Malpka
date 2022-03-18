using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : Interactable
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<HPManager>())
        {
            collision.gameObject.GetComponent<HPManager>().TakeDamage(2);
        }
    }
}
