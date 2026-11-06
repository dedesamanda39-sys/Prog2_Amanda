using UnityEngine;

public class PlataformaMovil : MonoBehaviour
{
    [Header("Configuracion de Puntos")]
    public Transform puntoA;
    public Transform puntoB;

    [Header("Parametros de movimientos")]
    public float velocidad = 2f;
    private Transform destinoActual;

    private void Start()
    {
        destinoActual = puntoB;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, destinoActual.position, velocidad * Time.deltaTime);

        if (Vector3.Distance(transform.position, destinoActual.position) < 0.1f)
        {
            destinoActual = (destinoActual == puntoA) ? puntoB : puntoA;
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            col.transform.SetParent(null);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            col.transform.SetParent(transform);
        }
    }

}

