using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public int vida = 3;
    public int cantidad = 1;

    public void TakeDamage(int danoRecibido)
    {
        vida -= danoRecibido;

        if (vida <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerHealth healt = collision.gameObject.GetComponent<PlayerHealth>();
            if (healt != null)
            {
                healt.TakeDamage(cantidad);
                Debug.Log("Enemigo toco al jugador " + cantidad + " de daño");
            }       
        }
    }
}
