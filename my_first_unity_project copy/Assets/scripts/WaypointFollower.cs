/* waypoint are key points that sets the begining
 and ending for the platform to move to.

*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] GameObject[] waypoints; //an array of points
    int currentWaypointIndex = 0;

    [SerializeField] float speed = 1f;

    void Update()
    {
        if (Vector3.Distance(transform.position,waypoints[currentWaypointIndex].transform.position) < .1f)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length)//if reach the end of waypoint array
            {
                currentWaypointIndex = 0;
            }
        }

        //move toward 
        transform.position = Vector3.MoveTowards(transform.position,waypoints[currentWaypointIndex].transform.position, speed * Time.deltaTime);
    }
}
