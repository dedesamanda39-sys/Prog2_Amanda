using UnityEngine;

public class EnemyDetector : MonoBehaviour
{
    private EnemyPersecutor persecusor;

    private void Awake()
    {
        persecusor = GetComponentInParent<EnemyPersecutor>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            persecusor.AsignarObjetivo(collision.transform);
        }
    }
}
