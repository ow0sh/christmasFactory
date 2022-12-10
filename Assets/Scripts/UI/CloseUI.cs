using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseUI : MonoBehaviour
{
    [SerializeField] private Canvas workbenchMenu;
    public void Test()
    {
        workbenchMenu.gameObject.SetActive(false);
    }
}
