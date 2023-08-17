using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Ability ability;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ability.Use(gameObject);
        }
    }
}
