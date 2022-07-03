using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class PointsManager : MonoBehaviour
{
    public static PointsManager Instance;

    #region serialized fields

    [SerializeField]
        private TextMeshProUGUI pointsTMP;
        [SerializeField]
        private TextMeshProUGUI starPointsTMP;

    #endregion
    
    #region fields

    private int starPoints = 0;
    private int points = 0;
    
    #endregion

    #region properties
    public int StarPoints
    {
        get => starPoints;
        set
        {
            starPoints = value;
            starPointsTMP.text = $"Star Points: {starPoints}";
        }
    }

    public int Points
    {
        get => points;
        set
        {
            points = value;
            pointsTMP.text = $"Points: {points}";
        }
    }
    #endregion
    
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
        StarPoints = 0;
        Points = 0;
    }
}

