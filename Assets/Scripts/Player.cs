using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private float hInput;
    [SerializeField] float speed;
    [SerializeField] float jumpForce;
    public int jumpCounter;
    private int actualJumpCounter;
    [SerializeField] public float hP;
    Rigidbody2D PlayerRB;
    SpriteRenderer PlayerSR;

    void Start()
    {
        PlayerRB = GetComponent<Rigidbody2D>();
        PlayerSR = GetComponent<SpriteRenderer>();
        actualJumpCounter = jumpCounter;
    }

   
    void Update()
    {
        hInput = Input.GetAxisRaw("Horizontal");

        Vector3 movementDirection = new Vector3(hInput, 0, 0).normalized;
        transform.Translate(movementDirection * (speed * Time.deltaTime));

        if (Input.GetKeyDown(KeyCode.A))
        {
            PlayerSR.flipX = true;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            PlayerSR.flipX = false;
        }
     
        if (Input.GetKeyDown(KeyCode.Space) && actualJumpCounter>=1)
        {
            PlayerRB.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            actualJumpCounter--;
        }

        if (hP <= 0)
        {
            SceneManager.LoadScene(0);
            
        }

    }

    public void onDamage(int damage, Vector3 direction, int knockBack)
    {
        
        hP = hP - damage;
        PlayerRB.AddForce(-direction * knockBack, ForceMode2D.Impulse);
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            SceneManager.LoadScene(2);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        actualJumpCounter = jumpCounter;
    }
}

