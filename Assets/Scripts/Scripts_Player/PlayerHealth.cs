using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int lives = 3;
    [SerializeField] private TMP_Text livesText;

    public void Start()
    {
        UpdateLivesText();
    }

    public void TakeDamage(int damage)
    {
        lives--;

        Debug.Log("Vidas restantes: " + lives);

        UpdateLivesText();

        if (lives <= 0)
        {
            Debug.Log("Game Over");

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void UpdateLivesText()
    {
        livesText.text = "Vidas: " + lives;
    }
}
