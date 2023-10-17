using UnityEngine;
using UnityEngine.UI;

public class TestBall : MonoBehaviour
{
    //[SerializeField] GameObject ball;
    //[SerializeField] GameObject body;
    Rigidbody rb;
    [SerializeField] private Text distanceText;
    public static bool touch = false;

    public static float dist;

    public GameObject player;
    private GameObject newBall;

    public GameObject projectpre;

    private GameObject projectileObject;
    private Vector3 projectilePosition;

    //LaunchProjectile projectile;

    /*
    private void Start()
    {
        //rb = ball.GetComponent<Rigidbody>();

        GameObject newBall = Instantiate(prefab);

        float dist = Vector3.Distance(newBall.transform.position, player.transform.position);
        distanceText.text = "Distance: " + dist.ToString("F1") + " meters";
        //distanceText.text = "Distance: " + Mathf.Round(dist) + " meters";
        Debug.Log("Distance: " + Mathf.Round(dist) + " meters");
    }
    */

    /*
    private void Start()
    {
        GameObject newBall = Instantiate(prefab);

        if (newBall != null)
        {
            float dist = Vector3.Distance(newBall.transform.position, player.transform.position);
            distanceText.text = "Distance: " + dist.ToString("F1") + " meters";
            Debug.Log("Distance: " + Mathf.Round(dist) + " meters");
        }
    }
    */

    /*
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            touch = true;
        }
    }
    */

    public void SetUpProjectile(GameObject incomingProjectile)
    {
        projectileObject = incomingProjectile;
    }

    private void OnEnable()
    {
        LaunchProjectile.OnProjectileLaunched += SetUpProjectile;
    }

    private void OnDisable()
    {
        LaunchProjectile.OnProjectileLaunched -= SetUpProjectile;
    }

    private void Start()
    {
        // Create a new ball object
        //newBall = Instantiate(prefab);
        //projectile = projectile.GetComponent<LaunchProjectile>();
        //projectpre = Resources.Load<GameObject>("projectile");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            touch = true;

            // Create a new ball object
            //newBall = Instantiate(prefab);
            //var ball = Instantiate(projectile);

        }
    }

    private void Update()
    {
        //GameObject prefab = Resources.Load<GameObject>("Ballll");
        //GameObject projectile = Instantiate(prefab).GetComponent<LaunchProjectile>().projectile;

        //GameObject bal2 = Resources.Load<GameObject>("Ballll(Clone)");
        /*
        if (touch == true)
        {
            // Calculate the distance between the new ball and the player
            float dist = Vector3.Distance(bal2.transform.position, player.transform.position);
            distanceText.text = "Distance: " + dist.ToString("F1") + " meters";
            Debug.Log("Distance: " + Mathf.Round(dist) + " meters");
        }
        */

        /*
        projectpre = Resources.Load<GameObject>("projectile");

        LaunchProjectile launchPro = GetComponent<LaunchProjectile>();
        GameObject projectile = launchPro.projectile;

        */


        //projectileObject = GameObject.Find("Projectile");
        if (projectileObject != null)
        {
            projectilePosition = projectileObject.transform.position;
        }

        if (touch)
        {
            /*
            // Calculate the distance between the new ball and the player
            float dist = Vector3.Distance(projectilePosition, player.transform.position);
            distanceText.text = "Distance: " + Mathf.Round(dist) + " meters";
            //Debug.Log("Distance: " + dist.ToString("F1") + " meters");
            */

            // Calculate the distance between the new ball and the player
            dist = Vector3.Distance(new Vector3(projectilePosition.x, 0, projectilePosition.z), new Vector3(player.transform.position.x, 0, player.transform.position.z));
            distanceText.text = "Distance: " + Mathf.Round(dist) + " M";
        }
    }


    /*
    private void Update()
    {
        if (touch == true)
        {
            //float dist = Vector3.Distance(gameObject.CompareTag("Ball").transform.position, body.transform.position);
            //distanceText.text = "Distance: " + dist.ToString("F1") + " meters";

            //float dist = Vector3.Distance(newBall.transform.position, player.transform.position);
            //distanceText.text = "Distance: " + dist.ToString("F1") + " meters";
        }
    }
    */
}