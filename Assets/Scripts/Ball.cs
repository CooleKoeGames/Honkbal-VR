using UnityEngine;

public class Ball : MonoBehaviour
{
    public static int points = 0;

    private void Start()
    {
        Destroy(gameObject, 20f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("point1"))
        {
            ScoreManager.instance.SaveScore(Mathf.Round(TestBall.dist));

            LaunchProjectile.shot = false;
            TestBall.touch = false;
            Destroy(gameObject);
        }
    }
}