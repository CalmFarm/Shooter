using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] GameObject robotExplosionVFX;
    [SerializeField] int maxHealth = 3;
    int currentHealth;

    GameManager gameManager;

    void Awake()
    {
        currentHealth = maxHealth;
    }

    private void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
        gameManager.UpdateEnemiesLeftText(1);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            gameManager.UpdateEnemiesLeftText(-1);
            SelfDestruct();
        }
    }

    public void SelfDestruct()
    {
        Instantiate(robotExplosionVFX, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
