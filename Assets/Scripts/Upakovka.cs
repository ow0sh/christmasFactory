using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upakovka : MonoBehaviour
{
   [SerializeField] private Canvas upakovkaMenu;
   private void OnMouseDown()
   {
      if(!GameObject.FindWithTag("CurrentItem")) return;
      var item = GameObject.FindWithTag("CurrentItem").GetComponent<ItemMovement>();

      if (!item.stopped) return;
      upakovkaMenu.gameObject.SetActive(true);
   }
}
