using UnityEngine;
using System.Collections;

public class SpawnGate : MonoBehaviour
{
    [SerializeField] GameObject enemyRobotPrefab;  
    [SerializeField] float spawnInterval = 5f;
    [SerializeField] Transform spawnPoint;
    
    PlayerHealth player;

    private void Start() 
    {
        player = FindFirstObjectByType<PlayerHealth>();
        StartCoroutine(SpawnEnemyRoutine());
    }                     

    IEnumerator SpawnEnemyRoutine()
    {
        while (player){
            Instantiate(enemyRobotPrefab, spawnPoint.position, spawnPoint.rotation);
            yield return new WaitForSeconds(spawnInterval);
        }
        
    }
    
}
