using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float life = 30f;
    public float hit = 5f;
    // nodig voor bal naar beneden
    //public Rigidbody rb;

    private void Awake()
    {
        Destroy(gameObject, life);
    }

    // nodig voor bal naar beneden
    /*
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    */

    private void OnTriggerEnter(Collider other)
    {
        /*
        Debug.Log("hit projectile script");

        if (other.gameObject.CompareTag("Ball"))
        {
            Debug.Log("hit projectile script tag");
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

        //Destroy(gameObject);
        //ScoreManager.scoreCount += 1;

        // nodig voor bal naar beneden
        //rb.velocity = Vector3.zero;
        //rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
        //Destroy(gameObject, hit);

        /*
        Destroy(GetComponent<Rigidbody>());

        Rigidbody ballRigidbody = other.GetComponent<Rigidbody>();
        ballRigidbody.velocity = Vector3.zero;
        ballRigidbody.useGravity = true;
        */
    }
}