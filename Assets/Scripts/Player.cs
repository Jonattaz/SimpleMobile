using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    // Velocidade do jogador
    float speed;

    [SerializeField]
    // Força do pulo
    float jumpForce;

    // Variavel que representa o rigidbody
    Rigidbody2D rb;

    [SerializeField]
    // Referência para a layer ground
    LayerMask ground;

    Animator anim;

    [SerializeField]
    AudioSource deathSoound;

    [SerializeField]
    AudioSource jumpSound;


    // Referência ao colisor do jogador
    Collider2D playerCollider;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerCollider = GetComponent<Collider2D>();
        anim = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);


        bool grounded = Physics2D.IsTouchingLayers(playerCollider, ground);

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            if (grounded)
            {
                jumpSound.Play();
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            }
        }

        anim.SetBool("Ground", grounded);

    }
}
