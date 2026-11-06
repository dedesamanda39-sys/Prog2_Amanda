using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float speed = 2f; // Que tan rapido se mueve
    [SerializeField] private float distance = 3f; // Cuanto se aleja de su posicion inicial

    private Vector3 startPosition;
    private bool movingRight = true;
    private SpriteRenderer sR;

    private void Start()
    {
        sR = GetComponent<SpriteRenderer>();
        startPosition = transform.position;
    }

    private void Update()
    {
        if (movingRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);

            if (transform.position.x >= startPosition.x + distance)
            {
                movingRight = false;
            }
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);

            if (transform.position.x <= startPosition.x - distance)
            {
                movingRight = true;
            }
        }

        sR.flipX = movingRight;
    }
}
