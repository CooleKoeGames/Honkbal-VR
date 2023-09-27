using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int scoreCount;

    private void Update()
    {
        scoreText.text = "Score: " + scoreCount;
    }
}