using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckObject : MonoBehaviour
{
    public GameObject TheBox;
    public GameObject TheToy;

    [SerializeField] private MoneyScript addMoney;
    [SerializeField] private int addCount;
    
    void Start()
    {
        addMoney = GameObject.FindGameObjectWithTag("Moneys").GetComponent<MoneyScript>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "ColorTag")
        {
            addMoney.MoneyCount += addCount;
            Destroy(other.gameObject);
        }
    }
}
