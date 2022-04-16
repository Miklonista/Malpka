using System;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    [SerializeField] private AudioClip _clip;
    protected virtual void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        OnTrigger();
        SoundManager.Instance.PlaySound(_clip);

    }

    protected virtual void OnTrigger()
    {
        Debug.Log($"OnTriggerEnter has not been implemented in {gameObject.name}");
    }

    protected virtual void OnCollisionEnter(Collision collision)
    {
        if (!collision.collider.CompareTag("Player")) return;
        OnCollide();
    }

    protected virtual void OnCollide()
    {
        Debug.Log($"OnCollisionEnter has not been implemented in {gameObject.name}");
   }
}
