using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workbench : MonoBehaviour
{
    [SerializeField] private Canvas workbenchMenu;
    private void OnMouseDown()
    {
        workbenchMenu.gameObject.SetActive(true);
    }
    
}
