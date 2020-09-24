using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace EnemyPathFinder
{
    /// <summary>
    /// De path class beheerd een array van waypoints. En houd bij bij welk waypoint een object is.
    /// Deze vormen samen het pad. 
    /// Logica die op het path niveau plaatsvindt gebeurt in deze class.
    /// Een deel van de functies welke je nodig hebt zijn hier al beschreven.
    /// </summary>
    public class Path : MonoBehaviour
    {
        public Waypoint[] wayPointsClass;
        public GameObject[] wayPoints;
        int count = 0;

        /// <summary>
        /// Deze functie returned het volgende waypoint waar naartoe kan worden bewogen.
        /// </summary>
        
        public void Awake()
        {
            wayPoints = GameObject.FindGameObjectsWithTag("WayPoint").OrderBy( go => go.name ).ToArray();
            foreach (GameObject wayPoints in wayPoints){
                Debug.Log(wayPoints.gameObject.name[count]);
            }
        }

        public Waypoint GetNextWaypoint()
        {

            // dit is nu niet goed, zorg ervoor dat het goede waypoint wordt teruggegeven.
            return null;
        }
    }
}