using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointsManager : MonoBehaviour
{
    private int points;
    
    //TODO: ZROBIC SKRYPT UI I TAM TYM ZARZADZAC
    [SerializeField]private TextMeshProUGUI interfacePoints;
    [SerializeField]private TextMeshProUGUI interfaceStarPoints;

    public static PointsManager Instance;
    private int starPoints;

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
        interfaceStarPoints.text = starPoints.ToString();
    }

    public void AddPoint(ItemSO value)
    {
        points+=value.points;
        starPoints += value.starPoints;
        interfacePoints.text = "Points " + points.ToString();
        interfaceStarPoints.text = "Star Points " + starPoints.ToString();
        if (starPoints == 3)
        {
            Debug.Log("Przechodzisz na nastêpny poziom");
        }    
    }

    
        
}

