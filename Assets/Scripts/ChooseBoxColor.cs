using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseBoxColor : MonoBehaviour
{
    [SerializeField] private GameObject box, openBox;
    [SerializeField] private Transform upakovkaPoint, boxPoint;
    [SerializeField] private Transform[] points;
    [SerializeField] private Material material;
    
    private GameObject _currentItem;
    private int _itemPrice;
    
    public void Paint()
    {
        _currentItem = GameObject.FindWithTag("CurrentItem");
        _itemPrice = _currentItem.GetComponent<ItemMovement>().itemPrice;

        Destroy(GameObject.FindWithTag("BoxOpen").gameObject);
        Destroy(_currentItem.gameObject);

        Instantiate(box, upakovkaPoint.position, Quaternion.identity);
        var currentBox = GameObject.FindWithTag("Box");
        var mrs = currentBox.GetComponentsInChildren<MeshRenderer>();
        for (var i = 0; i < mrs.Length; i++)
        {
            mrs[i].material = material;
        }

        var im = currentBox.GetComponent<ItemMovement>();
        im.points = points;
        im.box = openBox;
        im.boxPoint = boxPoint;
        im.itemPrice = _itemPrice;
        
        CloseUI.CloseUpakovka();
    }
}
