using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public Inventory Inventory;
    public GameObject InventoryPanel;
    public GameObject InventorySlot;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        RefreshInventoryUI();
    }

    private void RefreshInventoryUI()
    {
        foreach (Item item in Inventory.items)
        {
            Debug.Log(item);
        }
    }
}
