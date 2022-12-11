using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMovement : MonoBehaviour
{ 
    [HideInInspector] public Transform[] points;
    [HideInInspector] public bool stopped;

    [HideInInspector] public GameObject box;
    [HideInInspector] public Transform boxPoint;

    public int itemPrice;
    
    private Transform _currentPoint;
    private float _speed;
    private int _index;

    private void Start()
    {
        _speed = 5;
        _index = 0;
        _currentPoint = points[_index];
        stopped = false;
    }

    private void Update()
    {
        var position1 = transform.position;
        var position2 = _currentPoint.position;

        position1 = Vector3.MoveTowards(position1, position2, _speed * Time.deltaTime);
        transform.position = position1;
        
        if(position1 != position2) return;
        if (_currentPoint.tag == "Stop")
        {
            _speed = 0;
            stopped = true;
        }
        _index += 1;

        if (_index >= points.Length)
        {
            var mt = GameObject.Find("MoneysText");
            mt.GetComponent<MoneyScript>().MoneyCount += itemPrice;
            Destroy(gameObject);
            Instantiate(box, boxPoint.position, Quaternion.identity);
        }
        else
        {
            _currentPoint = points[_index];
        }
    }

    private void OnMouseDown()
    {
        if (stopped) _speed = 3;
    }
}
