using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Void : Interactable
{
    [SerializeField] private Transform spawnPoint;
    
    protected override void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        
        Debug.Log("kurwa cipeczka");
        SceneManager.LoadScene("Jungle Level");
    }
}
