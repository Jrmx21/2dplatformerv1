using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
   public int damage = 1;
   public GameManager gameManager;

private void Start() {
    gameManager = GameObject.FindObjectOfType<GameManager>();
}

    private void OnTriggerEnter2D(Collider2D other)
    {
        
            if (other.transform.CompareTag("ground"))
            {
                Destroy(gameObject);

            }
            if (other.CompareTag("player"))
            {
                 Destroy(this.gameObject);
                gameManager.TakeDamage(damage);
               
            }

    }
}

