using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int Health { get { return health; } }
    private int health = 100;
    public GameObject player;
    private int puntos = 0;
    public Image healthBar;

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
        healthBar.fillAmount = health / 100f;
    }
    public void AddPoints(int points)
    {
        puntos = puntos + points;
        Debug.Log("Puntos: " + puntos);
    }
}
