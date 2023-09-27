using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    /*
    public Text scoreText;

    private int score = 0;
    */

    public static int scoreValue = 0;
    private Text score;

    private void Start()
    {
        score = GetComponent<Text>();
    }

    private void Update()
    {
        score.text = "Score: " + scoreValue;
    }
}