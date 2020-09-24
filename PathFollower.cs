using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnemyPathFinder
{
    /// <summary>
    /// De path follower class is verantwoordelijk voor de beweging.
    /// Deze class zorgt ervoor dat het object (in Tower Defense) vaak een enemy, het path afloopt
    /// tip: je kunt de transform.LookAt() functie gebruiken en vooruitbewegen.
    /// </summary>
    public class PathFollower : MonoBehaviour
    {
         private Path _path;
        
        private int _currentPosition = 0;
        private float _speed;
        public Vector3 destination;
       

        void Awake() {
            _path = gameObject.GetComponent<Path>();
            transform.LookAt(_path.wayPoints[_currentPosition].transform.position);
            if (destination == null)
            {
                destination = _path.wayPoints[_currentPosition].transform.position;
            }
            Debug.Log(destination);
        }

        void LateUpdate() {
            
        }
    }
}