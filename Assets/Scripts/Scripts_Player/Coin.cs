using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerScore  playerScore = collision.GetComponent<PlayerScore>();

            if (playerScore != null)
            {
                playerScore.AddPoint();

                Destroy(gameObject);
            }
        }
    }
}
