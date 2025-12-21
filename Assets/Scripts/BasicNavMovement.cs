using System.Diagnostics;
using Unity.AI.Navigation.Editor;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


public class BasicNavMovement : MonoBehaviour
{
    [SerializeField] private NavMeshAgent navMeshAgent;
    [SerializeField] private Transform destination;
    [SerializeField] private Transform Back;
    
    void Start()
    {
       navMeshAgent.agentTypeID = 0;
        navMeshAgent.SetDestination(destination.position);
        //For back, player got jetpack
      
       
        
           
            navMeshAgent.agentTypeID = 1;
            navMeshAgent.SetDestination(Back.position);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //navMeshAgent.agentTypeID = 1;
       // navMeshAgent.SetDestination(Back.position);
    }


    void Update()
    {
        
    }
}
