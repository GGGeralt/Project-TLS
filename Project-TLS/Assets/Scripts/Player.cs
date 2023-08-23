using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Creature
{
    public static Player Instance { get; private set; }
    public Ability ability;


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(Instance);
        }
        else
        {
            Instance = this;
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ability.Use(gameObject);
        }
    }
}
