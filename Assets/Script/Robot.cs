using StarterAssets;
using UnityEngine;
using UnityEngine.AI;

public class Robot : MonoBehaviour
{
    FirstPersonController player;
    NavMeshAgent agent;

    const string PLAYER_TAG = "Player";

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Start()
    {
        player = FindFirstObjectByType<FirstPersonController>();
    }

    void Update()
    {
        agent.SetDestination(player.transform.position);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(PLAYER_TAG))
        {
            EnemyHealth enemyHealth = GetComponent<EnemyHealth>();
            enemyHealth.SelfDestruct();
        }
    }
}
