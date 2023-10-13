using UnityEngine;
using UnityEngine.UI;

public class DistanceScoreScript : MonoBehaviour
{
    public GameObject startPos;
    public Text scoreText;
    public GameObject scoreTextObj;

    private float distance;

    private void Start()
    {
        scoreText = scoreTextObj.GetComponent<Text>();
    }

    private void Update()
    {
        //distance = (startPos.transform.position + this.transform.position);
    }
}