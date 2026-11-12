using UnityEngine;

public class EnemyPersecutor : MonoBehaviour
{
    public float velocidad = 1.5f;
    [HideInInspector] public Transform jugador;
    [SerializeField] private EnemyBase enemyBase;

    [Header("Configuracion de disparo")]
    public GameObject proyectilPrefab;
    public Transform puntoDeDisparo;
    public float cadenciaDisparo = 2f;
    private float temporizador;

    private void Awake()
    {
        enemyBase = GetComponent<EnemyBase>();
    }

    private void Update()
    {
        if (jugador != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, jugador.position, velocidad *  Time.deltaTime);

            temporizador += Time.deltaTime;
            if (temporizador >= cadenciaDisparo)
            {
                Disparar();
                temporizador = 0f;
            }
        }
    }

    void Disparar()
    {
        if(proyectilPrefab == null)
        {
            Vector3 posicionSpawn = puntoDeDisparo != null ? puntoDeDisparo.position : transform.position;
            GameObject bala = Instantiate(proyectilPrefab, posicionSpawn, Quaternion.identity);
            Vector2 direccionAlJugador = (jugador.position - posicionSpawn).normalized;
            EnemyProjectile scriptBala = bala.GetComponent<EnemyProjectile>();

            if (scriptBala != null)
            {
                scriptBala.SetDireccion(direccionAlJugador);
            }
        }
    }

    public void AsignarObjetivo(Transform nuevoObjetivo)
    {
        if (jugador == null)
        {
            jugador = nuevoObjetivo;

            EnemyMovement patrulla = GetComponent<EnemyMovement>();
            if (patrulla != null) patrulla.enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Debug.Log("Daño al jugador " + enemyBase.cantidad);
        }
    }
}
