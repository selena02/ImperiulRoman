using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Cat : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    private NavMeshAgent agent;
   
    private bool isWalking;
    private bool isSitting;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        agent.destination = player.position;
        CheckWalkingStatus();
    }
    private void CheckWalkingStatus()
    {
        isWalking = agent.velocity.magnitude > 0.1f;
   
        if (isWalking)
        {            
            isSitting = false;
        }
        else
        {
            // Cat is not walking
            isSitting = true;
        }
    }
    public bool IsWalking()
    {
        return isWalking;
    }

    public bool IsSitting() 
    { 
        return isSitting; 
    }
}
