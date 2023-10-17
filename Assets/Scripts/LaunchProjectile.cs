using UnityEngine;

public class LaunchProjectile : MonoBehaviour
{
    public delegate void LaunchDelegate(GameObject projectileObj);
    public static event LaunchDelegate OnProjectileLaunched;

    public Transform launchPoint;
    public GameObject projectile;
    public float launchVelocity = 15f;

    [Header("***Trajectory Display***")]
    public LineRenderer lineRenderer;
    public int linePoints = 175;
    public float timeIntervalInPoints = 0.01f;

    private float timeSinceLastShot = 0f;
    private float timeBetweenShots = 5f;

    public static bool shot = false;

    private void Update()
    {
        timeSinceLastShot += Time.deltaTime;

        if (lineRenderer != null)
        {
            if (Input.GetMouseButton(1))
            {
                DrawTrajectory();
                lineRenderer.enabled = true;
            }
            else
            {
                lineRenderer.enabled = false;
            }
        }
    }

    public void Shoot()
    {
        if (shot == false && ScoreManager.instance.currentRound <= 2)
        {
            ScoreManager.instance.scoreText.text = "Distance: 0 M";

            GameObject projectileObj = Instantiate(projectile, launchPoint.position, launchPoint.rotation);
            var projectileRigidbody = projectileObj.GetComponent<Rigidbody>();
            projectileRigidbody.velocity = launchPoint.up * launchVelocity;
            // kan mischien weg als de code beter werkt dat kan mishein als ik de projectile zoek met een tag
            projectileObj.name = "Projectile";
            // dit stukje hier tussen
            timeSinceLastShot = 0f;
            shot = true;

            //ScoreManager.instance.SetCanvas();

            if (OnProjectileLaunched != null)
            {
                OnProjectileLaunched(projectileObj);
            }
        }
        //else if (ScoreManager.instance.currentRound >= 2 && shot == false)
        //{
        //    ScoreManager.instance.SetCanvas();
        //}

        //if (ScoreManager.instance.currentRound >= 2)
        //{
        //    ScoreManager.instance.SetCanvas();
        //}
    }

    private void DrawTrajectory()
    {
        var origin = launchPoint.position;
        var startVelocity = launchVelocity * launchPoint.up;
        lineRenderer.positionCount = linePoints;
        var time = 0f;

        for (var i = 0; i < linePoints; i++)
        {
            var x = (startVelocity.x * time) + (Physics.gravity.x / 2 * time * time);
            var y = (startVelocity.y * time) + (Physics.gravity.y / 2 * time * time);
            var point = new Vector3(x, y, 0);
            lineRenderer.SetPosition(i, origin + point);
            time += timeIntervalInPoints;
        }
    }
}