using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Creature : MonoBehaviour
{
    public StatChangeable health;
    public Stat movementSpeed;
}
