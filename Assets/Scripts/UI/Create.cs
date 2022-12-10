using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Create : MonoBehaviour
{
    [SerializeField] private GameObject toy;
    [SerializeField] private Transform[] points;

    public void ToyCreate()
    {
        var obj = toy.GetComponent<ItemMovement>();
        obj.points = points;
        Instantiate(toy, points[0].position, Quaternion.identity);
    }
}
