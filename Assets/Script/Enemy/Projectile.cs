using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 30f;

    Rigidbody rb;
    int damage;

    private void Awake() 
    {
        rb = GetComponent<Rigidbody>();
    }
    
    private void Start() 
    {
        rb.linearVelocity = transform.forward * speed;
    }

    public void Init(int damage)
    {
        this.damage = damage;
    }

    private void OnTriggerEnter(Collider other) 
    {
        PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
        playerHealth?.TakeDamage(damage);
        Destroy(gameObject);
    }
}
