using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int maxRounds = 3;

    public float[] allScores = new float[3];
    public Text[] allScoresText = new Text[3];

    //private int currentRound = 0;
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
        //allScores = new int[maxRounds];
        //allScoresText = new Text[maxRounds];
    }

    public void SaveScore(float incomingScore)
    {
        // dit is dat hij alleen werkt als je de bat raakt
        if (currentRound < allScores.Length && TestBall.touch == true)
        {
            allScores[currentRound] = incomingScore;
            allScoresText[currentRound].text = incomingScore.ToString() + " M";
            //allScoresText[currentRound].text = currentRound + ": " + incomingScore.ToString() + " M";
            currentRound++;

            float sum = allScores.Sum();
            totalText.text = "Total: " + sum.ToString() + " M";
        }

        // dit is dat hij als je mist dat hij nul neer zet
        //if (currentRound < allScores.Length)
        //{
        //    allScores[currentRound] = incomingScore;
        //    allScoresText[currentRound].text = incomingScore.ToString() + " M";
        //    //allScoresText[currentRound].text = currentRound + ": " + incomingScore.ToString() + " M";
        //}
        //currentRound++;

        //float sum = allScores.Sum();
        //totalText.text = "Total: " + sum.ToString() + " M";

    }







    /*
    public void Point()
    {
        Debug.Log("point 1");
    }
    */

    /*
    public TextMeshProUGUI scoreText;
    public static int scoreCount;

    public GameObject player;
    public GameObject ball;
    private float distance;
    [SerializeField] private Text distanceText;
    */

    //private bool ballHit = false;

    /*
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bat"))
        {
            ballHit = true;
        }
    }
    */

    /*
    private void Start()
    {
        //player = GameObject.Find("XR Origin (XR Rig)");
        //ball = GameObject.Find("Bal (4) S");
    }
    */

    /*
    private void Update()
    {
        scoreText.text = "Score: " + scoreCount;

        distance = Vector3.Distance(player.transform.position, ball.transform.position);
        distanceText.text = distance.ToString("F1") + " Meters";

        
        //if (ballHit)
        //{
            //distance = Vector3.Distance(player.transform.position, ball.transform.position);
            //Debug.Log("Distance between player and ball: " + distance);
            //distanceText.text = distance.ToString("F1") + " Meters";
            //ballHit = false;
        //}
        
    }
    */
}