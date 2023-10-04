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
            points += 1;
            Debug.Log("you have " + points.ToString() + " points");
            Destroy(gameObject);
        }
        /*
        if (other.CompareTag("point2"))
        {
            points += 2;
            Debug.Log("you have " + points.ToString() + " points");
            Destroy(gameObject);
        }

        if (other.CompareTag("point3"))
        {
            points += 3;
            Debug.Log("you have " + points.ToString() + " points");
            Destroy(gameObject);
        }

        if (other.CompareTag("point4"))
        {
            points += 4;
            Debug.Log("you have " + points.ToString() + " points");
            Destroy(gameObject);
        }

        if (other.CompareTag("point5"))
        {
            points += 5;
            Debug.Log("you have " + points.ToString() + " points");
            Destroy(gameObject);
        }

        if (other.CompareTag("point6"))
        {
            points += 6;
            Debug.Log("you have " + points.ToString() + " points");
            Destroy(gameObject);
        }
        */
    }
}