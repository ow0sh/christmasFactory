using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyIdea : MonoBehaviour
{
    public MoneyScript cash;
    public int IdeaCost;

    public GameObject CurrentIdeaMenu;
    public GameObject NextIdeaMenu;
    // Start is called before the first frame update
    void Start()
    {
        cash = GameObject.FindGameObjectWithTag("Moneys").GetComponent<MoneyScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyButton()
    {
        if (cash.MoneyCount >= IdeaCost)
        {
            CurrentIdeaMenu.SetActive(false);
            NextIdeaMenu.SetActive(true);
            cash.MoneyCount -= IdeaCost;
        }
    }
}
