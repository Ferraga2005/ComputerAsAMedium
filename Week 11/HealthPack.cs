using UnityEngine;

public class HealthPack : MonoBehaviour
{
    public PlayerHealth playerHealth;

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            { 
                if(playerHealth.health == 100)
                {
                    //Nothing ever happens.
                }
                else
                {
                    playerHealth.health += 10;
                    Destroy(gameObject);
                }
            }
        }
    }
}
