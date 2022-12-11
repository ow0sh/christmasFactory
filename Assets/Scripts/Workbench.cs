using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workbench : MonoBehaviour
{
    [SerializeField] private Canvas workbenchMenu;
    private void OnMouseDown()
    {
        if (GameObject.FindWithTag("CurrentItem")) return;
        workbenchMenu.gameObject.SetActive(true);
    }
    
}
