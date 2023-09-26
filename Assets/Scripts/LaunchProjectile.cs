using UnityEngine;

public class LaunchProjectile : MonoBehaviour
{
    public Transform launchPoint;
    public GameObject projectile;
    public float launchVelocity = 15f;

    [Header("***Trajectory Display***")]
    public LineRenderer lineRenderer;
    public int linePoints = 175;
    public float timeIntervalInPoints = 0.01f;

    private float timeSinceLastShot = 0f;
    private float timeBetweenShots = 5f;

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

        if (timeSinceLastShot >= timeBetweenShots)
        {
            var projectileInstance = Instantiate(projectile, launchPoint.position, launchPoint.rotation);
            var projectileRigidbody = projectileInstance.GetComponent<Rigidbody>();
            projectileRigidbody.velocity = launchPoint.up * launchVelocity;
            timeSinceLastShot = 0f;
        }
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