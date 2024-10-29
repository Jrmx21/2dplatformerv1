using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public bool canJump = true;
    public int health = 6;
    public float speed = 5.0f;
    public float jumpForce = 300.0f;
    public bool canDoubleJump = false;
    private Rigidbody2D rb;
    public int empujeEnemigo1 = 10;
    public GameObject enemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        // Control del movimiento horizontal
        rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);
        if (horizontalInput != 0)
        {
         //dash con cooldown de 1 segundo pulsando space cuando esta corriendo para un lado u otro
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(new Vector2(horizontalInput * 2000, 0));
            }

            if(horizontalInput < 0)
            {
                // Debug.Log("izquierda");
            }
            else
            {
                // Debug.Log("derecha");
            }
            gameObject.GetComponent<Animator>().SetBool("mooving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = horizontalInput < 0;
        }
        else
        {
            gameObject.GetComponent<Animator>().SetBool("mooving", false);
        }
      
       
        // Control del salto
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (canJump)
            {
                canJump = false;
                canDoubleJump = true;
                rb.AddForce(new Vector2(0, jumpForce));
                gameObject.GetComponent<Animator>().SetBool("isGrounded", false);
                Debug.Log("salto normal");
            }
            else if (canDoubleJump)
            {
                canDoubleJump = false;
                rb.velocity = new Vector2(rb.velocity.x, 0); // Cancelar la velocidad para un mejor control del doble salto
                rb.AddForce(new Vector2(0, jumpForce));
                Debug.Log("doble salto");
            }
        }
        if (health <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Main Menu");
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("ground"))
        {
            canJump = true;
            canDoubleJump = false;
            gameObject.GetComponent<Animator>().SetBool("isGrounded", true);
        }
    }
}
