using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UImanager : MonoBehaviour
{
    public TextMeshProUGUI coinAmountText;

    // Start is called before the first frame update
    void Start()
    {
        coinAmountText.text = "Coins: 0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
