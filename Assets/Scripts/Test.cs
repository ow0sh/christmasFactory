using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private Material material;

    private void Start()
    {
        var test = GetComponentInChildren<MeshRenderer>();
        test.material = material;
    }
}  
