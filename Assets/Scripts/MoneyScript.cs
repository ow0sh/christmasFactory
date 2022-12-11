using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoneyScript : MonoBehaviour
{
    public int MoneyCount;
    public TextMeshProUGUI Text;

    private void Start()
    {
        Text = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        Text.text = MoneyCount.ToString() + "p";
    }
}
