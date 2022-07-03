using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemList",menuName = "Items/NewItemList", order = 1)]

public class ItemListSO : ScriptableObject
{
    public List<GameObject> itemList = new List<GameObject>();
    
    
}
