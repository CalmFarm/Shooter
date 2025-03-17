using Cinemachine;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [Range(1, 10)]
    [SerializeField] int startingHealth = 5;
    [SerializeField] CinemachineVirtualCamera deathVirtualCamera;
    [SerializeField] Transform weaponCamera;
    [SerializeField] Image[] shieldBars;

    int currentHealth;
    int gameOverVirtualCameraPriority = 20;

    void Awake()
    {
        currentHealth = startingHealth;
        AdjustShieldUI();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        AdjustShieldUI();

        if (currentHealth <= 0)
        {
            weaponCamera.parent = null;
            deathVirtualCamera.Priority = gameOverVirtualCameraPriority;
            Destroy(this.gameObject);
        }
    }

    void AdjustShieldUI()
    {
        for (int i = 0; i < shieldBars.Length; i++)
        {
            if (i < currentHealth)
            {
                shieldBars[i].enabled = true;
            }
            else
            {
                shieldBars[i].enabled = false;
            }
        }
    }
}
