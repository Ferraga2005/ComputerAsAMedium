using UnityEngine;
using System.Collections;
using TMPro;

public class SpawnerTrap : MonoBehaviour
{

    public GameObject enemy1;
    public GameObject enemy2;
    public TMP_Text trapText;
    public int timer;
    
    private PolygonCollider2D polCol;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        polCol = GetComponent<PolygonCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D otherObject)
    {
        if (otherObject.CompareTag("Player"))
        {
            StartCoroutine(SpawnEnemies());
            polCol.enabled = false;
        }
    }

    IEnumerator SpawnEnemies()
    {
            
        for(int i = timer; i > 0; i--) 
        {
            trapText.text = "Enemies appearing in: " + i;
            yield return new WaitForSeconds(1f);
        }

        if(enemy1 != null) 
        {
        enemy1.SetActive(true);
        }
        if(enemy2 != null) 
        {
        enemy2.SetActive(true);
        }

        trapText.text = "";




    }
}
