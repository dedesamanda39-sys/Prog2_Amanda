using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    [SerializeField] private float velocidad = 5f;
    [SerializeField] private float tiempoVida = 4f;

    private Vector2 direccion = Vector2.left;

    private void Start()
    {
        Destroy(gameObject, tiempoVida);
    }

    private void Update()
    {
        transform.position += (Vector3)(direccion * velocidad * Time.deltaTime);
    }

    public void SetDireccion(Vector2 nuevaDireccion)
    {
        direccion = nuevaDireccion.normalized;
    }
}
