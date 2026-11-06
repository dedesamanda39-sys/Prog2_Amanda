using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5f; //Velocidad Horizontal Inicial
    private Rigidbody2D rb; //Controla las fisicas
    private PlayerInput playerInput; //Unir scripts
    private Animator animator;
    private SpriteRenderer sR;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        playerInput = GetComponent<PlayerInput>();
        animator = GetComponent<Animator>();
        sR = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate() //Aplica movimiento fisico
    {
        float movex = playerInput.moveInput;
        animator.SetFloat("Speed", Mathf.Abs(movex));
        rb.linearVelocity = new Vector2(movex * speed, rb.linearVelocity.y);

        if (movex > 0)
        {
            sR.flipX = false;
        }

        else if (movex < 0)
        {
            sR.flipX=true;
        }
    }
}
