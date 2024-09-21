using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{   

    public bool isActive = false;
    private NavMeshAgent agent;
    [SerializeField] private Transform player;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //agent.SetDestination(player.position);        
    }

    void Update()
    {
        if(!isActive){

            if(player != null) agent.SetDestination(player.position);
            Debug.Log("Я активный!");

        }

        else{

            if(player != null) agent.SetDestination(agent.transform.position);

        }
    }
}
