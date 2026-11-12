using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float velocidad = 2f;
    public float distance = 5f;

    private Vector2 inicialPos;
    private int direccion = -1;

    private void Start()
    {
        inicialPos = transform.position;
    }

    private void Update()
    {
        transform.Translate(Vector2.right * direccion * velocidad * Time.deltaTime);

        if (direccion == -1 && transform.position.x <= inicialPos.x - distance)
        {
            direccion = 1;
        }
        else if (direccion == 1 && transform.position.x >= inicialPos.x + distance)
        {
            direccion = -1;
        }
    }
}
