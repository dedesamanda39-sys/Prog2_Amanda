using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [Header("Disparo")]
    [SerializeField] private GameObject proyectilPrefab;
    [SerializeField] private Transform FirePoint;
    [SerializeField] private float tiempoEntreDisparos = 2f;

    private float temporizador;

    private void Update()
    {
        temporizador += Time.deltaTime;

        if (temporizador >= tiempoEntreDisparos)
        {
            Disparar();
            temporizador = 0f;
        }
    }

    private void Disparar()
    {
        Instantiate(proyectilPrefab, FirePoint.position, FirePoint.rotation);
    }
}
