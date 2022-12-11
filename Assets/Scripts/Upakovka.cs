using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upakovka : MonoBehaviour
{
   private void OnMouseDown()
   {
      var item = GameObject.FindWithTag("CurrentItem").GetComponent<ItemMovement>();

      if (!item.stopped) return;
      Debug.Log("Stopped");
   }
}
