using TMPro;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    private int score = 0;

    [SerializeField] private TMP_Text scoreText;

    private void Start()
    {
        UpdateScoreText();
    }

    public void AddPoint()
    {
        score++;

        Debug.Log("Puntos: " + score);

        UpdateScoreText();
    }
    
    private void UpdateScoreText()
    {
        scoreText.text = "Puntos: " + score;
    }
}
