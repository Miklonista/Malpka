using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointsManager : MonoBehaviour
{
    private int points;

    [SerializeField]private TextMeshProUGUI interfacePoints;

    public static PointsManager Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }
    private void Start()
    {
        interfacePoints.text = points.ToString();
    }

    public void AddPoint(int value)
    {
        points+=value;
        interfacePoints.text = points.ToString();
    }
}

