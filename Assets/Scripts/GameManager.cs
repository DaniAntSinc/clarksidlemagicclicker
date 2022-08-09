using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static float currency;
    public Text currencyUI;

    float currencyPerSec;
    float countingToASecond;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currencyUI.text = currency.ToString("F0");

        countingToASecond *= Time.deltaTime;
        if (countingToASecond >= 1)
        {
            currency += currencyPerSec;
            countingToASecond = 0;
        }
    }
}
