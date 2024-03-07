using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionController : MonoBehaviour
{
    public string targetTag = "EnemyVehicle"; // Tag to identify visible targets
    public float sightRange = 10f; // Maximum distance for line of sight
    public int rayCount = 20; // Number of rays to cast

    private void Update()
    {
        CheckLineOfSight();
    }

    private void CheckLineOfSight()
    {
        RaycastHit hit;

        for (int i = 0; i < rayCount; i++)
        {
            // Calculate angle for the ray
            float angle = (360f / rayCount) * i;
            Vector3 direction = Quaternion.Euler(0, angle, 0) * transform.forward;

            // Cast a ray in the calculated direction
            if (Physics.Raycast(transform.position, direction, out hit, sightRange))
            {
                // Check if the ray hits a game object with the target tag
                if (hit.collider.CompareTag(targetTag))
                {
                    // You can do something with the visible target here
                    Debug.Log("T90 seen");
                    Debug.DrawLine(transform.position, hit.point, Color.green);
                }
                else
                {
                    Debug.Log("Hitting Something else");
                    Debug.DrawLine(transform.position, hit.point, Color.red);
                }
            }
            else
            {
                // Draw the ray if it didn't hit anything
                Debug.DrawRay(transform.position, direction * sightRange, Color.yellow);
            }
        }
    }
}
