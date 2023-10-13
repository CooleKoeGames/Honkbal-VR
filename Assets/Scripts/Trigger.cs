using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject ball;

    /*
    private void Awake()
    {
        ball.tag = "Ball";
    }
    */


    private void OnTriggerEnter(Collider other)
    {
        /*
        Debug.Log("hit trigger script");

        if (other.gameObject.CompareTag("Ball"))
        {
            Debug.Log("hit trigger script tag");
        }
        */

        /*
        Debug.Log(other.gameObject.name);

        Debug.Log("hit trigger");
        if (ball.CompareTag("Ball"))
        {
            Debug.Log("contact");
            ball.tag = "NoBall";
            Debug.Log($"new tag set to: {gameObject.tag}");
        }
        else
        {
            Debug.Log($"Object with tag: {other.tag} has entered");
        }
        */

        /*
        Debug.Log("hit trigger");
        if (other.gameObject.CompareTag("Ball"))
        {
            //Debug.Log("changes tag");
            Debug.Log("Herbivore is making contact!");
            gameObject.tag = "NoBall";
            Debug.Log($"new tag set to: {gameObject.tag}");
            // Destroy(gameObject, hit);
            ScoreManager.scoreCount += 1;
        }
        else
        {
            Debug.Log($"Object with tag: {other.tag} has entered");
        }


        */
    }

































    /*
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            //Debug.Log("changes tag");
            Debug.Log("Herbivore is making contact!");
            gameObject.tag = "NoBall";
            Debug.Log($"new tag set to: {gameObject.tag}");
            // Destroy(gameObject, hit);
            ScoreManager.scoreCount += 1;
        }
    }
    */
}