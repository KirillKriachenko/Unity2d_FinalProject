using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Navigation : MonoBehaviour {

    private UnityEngine.AI.NavMeshAgent nav;

    void Start()
    {
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        CurrentNavigation.target = transform.position;
    }

    void Update()
    {
        CurrentNavigation.isPointer = nav.hasPath;
        nav.SetDestination(CurrentNavigation.target);
    }
}
