using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public Inventory Inventory;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
