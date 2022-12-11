using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OrdersScript : MonoBehaviour
{
    public SpriteRenderer CurrentSprite;

    public MoneyScript moneys;

    public Sprite OrderImage1;
    public Sprite OrderImage2;
    public Sprite OrderImage3;
    public Sprite OrderImage4;
    public Sprite OrderImage5;
    public Sprite OrderImage6;

    // Start is called before the first frame update
    void Start()
    {
        moneys = GameObject.FindGameObjectWithTag("Moneys").GetComponent<MoneyScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(moneys.MoneyCount >= 200)
        {
            CurrentSprite.sprite = OrderImage1;
        }
    }
}
