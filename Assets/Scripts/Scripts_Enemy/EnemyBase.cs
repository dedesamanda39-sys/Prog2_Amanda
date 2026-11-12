using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public int vida = 3;
    public int cantidad = 1;

    public void TakeDamage(int cantidad)
    {
        vida -= cantidad;

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
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(1);
            Debug.Log("Enemigo toco al jugador " + cantidad + " de daño");
        }
    }

}
