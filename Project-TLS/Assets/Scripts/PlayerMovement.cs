using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    NavMeshAgent agent;
    Camera cam;
    [SerializeField] LayerMask ground;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        cam = Camera.main;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100, ground))
            {
                agent.SetDestination(hit.point);
            }
        }
    }
}
