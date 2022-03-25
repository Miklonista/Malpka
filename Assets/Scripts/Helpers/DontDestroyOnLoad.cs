using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    [SerializeField] 
    private List<GameObject> objectsToKeep;

    private void Awake()
    {
        foreach (var obj in objectsToKeep)
        {
            DontDestroyOnLoad(obj);
        }
    }
}
