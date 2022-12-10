using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workbench : MonoBehaviour
{
    [SerializeField] private Canvas workbenchMenu;
    [SerializeField] private Transform startPoint;

    public static bool itemStatus, canvasStatus;
    private void OnMouseDown()
    {
        workbenchMenu.gameObject.SetActive(true);
    }
    
}
