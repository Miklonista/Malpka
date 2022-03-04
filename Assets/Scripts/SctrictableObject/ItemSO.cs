using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemData",menuName = "Items/NewItem", order = 1)]
public class ItemSO : ScriptableObject
{
    public int points;
    public Material coinMaterial;
    public int starPoints;  
    // Punkty przyznawane za zebranie obiektu Star. Trzy punkty pozwalaj� na przej�cie do nast�pnego poziomu.
    //todo: enum class type {coin, star, banana}, points -> value
}
