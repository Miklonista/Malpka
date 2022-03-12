using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemData",menuName = "Items/NewItem", order = 1)]
public class ItemSO : ScriptableObject
{
    public int points;
    public Material coinMaterial;
   // public int starPoints;  
   //zakomentowałem to, bo w sumie raczej kazda gwiazdka powinna dawac 1 punkt, a do tego nie potrzebujemy tworzyc ItemSO osobnego ~Wojtek
    // Punkty przyznawane za zebranie obiektu Star. Trzy punkty pozwalają na przejście do następnego poziomu.
    //todo: enum class type {coin, star, banana}, points -> value
}
