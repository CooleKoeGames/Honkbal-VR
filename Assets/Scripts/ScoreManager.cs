using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int maxRounds = 3;

    public float[] allScores = new float[3];
    public Text[] allScoresText = new Text[3];

    public int currentRound = 0;

    public Text scoreText;

    public Text totalText;

    private int score = 0;


    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        scoreText.text = "Distance: " + score.ToString() + " M";
    }

    public void SaveScore(float incomingScore)
    {
        if (currentRound < allScores.Length && TestBall.touch == true)
        {
            allScores[currentRound] = incomingScore;
            allScoresText[currentRound].text = incomingScore.ToString() + " M";
            currentRound++;

            float sum = allScores.Sum();
            totalText.text = "Total: " + sum.ToString() + " M";
        }
    }
}