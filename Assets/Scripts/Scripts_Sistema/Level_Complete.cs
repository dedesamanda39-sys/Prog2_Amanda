using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Complete : MonoBehaviour
{
    public GameObject VictoriaTexto;
    public GameObject RestarButton;

    public void RestarButtoon()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            VictoriaTexto.SetActive(true);
            RestarButton.SetActive(true);

            Rigidbody2D rb = other.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                rb.linearVelocity = Vector2.zero;
            }

            other.GetComponent<PlayerInput>().enabled = false;
            other.GetComponent<PlayerController>().enabled = false;
            other.GetComponent<PlayerJump>().enabled = false;

            Debug.Log("Nivel Completado");
        }
    }
}
