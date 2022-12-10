using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform[] points;

    private Transform _currentPoint;
    private int _index;
    private bool _stopped;

    private void Start()
    {
        _index = 0;
        _currentPoint = points[_index];
        _stopped = false;
    }

    private void Update()
    {
        var position1 = transform.position;
        var position2 = _currentPoint.position;

        position1 = Vector3.MoveTowards(position1, position2, speed * Time.deltaTime);
        transform.position = position1;
        
        if(position1 != position2) return;
        if (_currentPoint.tag == "Stop")
        {
            speed = 0;
            _stopped = true;
        }
        _index += 1;

        if (_index >= points.Length)
        {
            Destroy(gameObject);
        }
        else
        {
            _currentPoint = points[_index];
        }
    }

    private void OnMouseDown()
    {
        if (_stopped) speed = 3;
    }
}
