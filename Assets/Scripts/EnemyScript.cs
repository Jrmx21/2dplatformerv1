using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameManager gameManager;
    public string name;
    public int points;
    public bool hurtsPlayer;
    public int damage;
    public bool isEnchanted;
    public string resourcePath;
    public SfxManager sfxManager;
    public Sprite sprite; // Cambia el recurso de tipo Sprite

    private void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
        sfxManager = FindObjectOfType<SfxManager>();
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
            if (hurtsPlayer)
            {
                gameManager.TakeDamage(damage);

            }
            else
            {
                gameManager.AddPoints(points);
                sfxManager.PlaySfx(sfxManager.pickupSfx);

            }



        }

    }
}

