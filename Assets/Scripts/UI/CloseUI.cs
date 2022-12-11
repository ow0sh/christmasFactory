using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseUI : MonoBehaviour
{
    public static void CloseButton()
    {
        var workbenchMenu = GameObject.Find("WorkbenchMenu");
        workbenchMenu.gameObject.SetActive(false);
    }

    public static void CloseUpakovka()
    {
        var upakovkaMenu = GameObject.Find("Upakovka");
        upakovkaMenu.gameObject.SetActive(false);
    }
}
