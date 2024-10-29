using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int Health { get { return health; } }
    private int health = 6;
    public GameObject player;
    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Vida: " + health);
        if (health <= 0)
        {
            Debug.Log("Game Over");
            Destroy(player);
            SceneManager.LoadScene("Main Menu");
        }
    }
}
