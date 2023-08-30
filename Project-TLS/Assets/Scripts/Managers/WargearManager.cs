using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WargearManager : MonoBehaviour
{
    public Wargear wargear;
    public Item item;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            wargear.item1 = item;
        }
    }

    private void OnApplicationQuit()
    {
        //wargear.item1 = null;
    }
}
