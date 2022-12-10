using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseUI : MonoBehaviour
{
    [SerializeField] private Canvas workbenchMenu;
    public void CloseButton()
    {
        workbenchMenu.gameObject.SetActive(false);
    }
}
