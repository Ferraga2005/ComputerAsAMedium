using UnityEngine;

public class SpawnerTrap : MonoBehaviour
{

    public GameObject enemy1;
    public GameObject enemy2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D otherObject)
    {
        if (otherObject.CompareTag("Player"))
        {
            enemy1.SetActive(true);
            enemy2.SetActive(true);
        }
    }
}
