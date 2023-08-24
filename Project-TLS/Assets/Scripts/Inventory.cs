using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "inventory", menuName = "new Inventory")]
public class Inventory : ScriptableObject
{
    public List<Item> items;
}
