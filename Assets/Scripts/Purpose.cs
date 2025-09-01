using UnityEngine;
using System.Collections.Generic;

public class Purpose : MonoBehaviour
{
    [SerializeField] private List<Transform> _wayPoints;
    [SerializeField] private float _movementSpeed;

    private int _currentWayPoint = 0;

    private void Update()
    {
        if (transform.position == _wayPoints[_currentWayPoint].position)
            _currentWayPoint = (_currentWayPoint + 1) % _wayPoints.Count;

        transform.position = Vector3.MoveTowards(transform.position, _wayPoints[_currentWayPoint].position, _movementSpeed * Time.deltaTime);
    }
}