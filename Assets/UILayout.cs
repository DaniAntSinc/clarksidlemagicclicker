using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UILayout : MonoBehaviour
{
    public Slider classLevelSlider;
    public TextMeshProUGUI classValue;
    public float buyClassCost, buySeatCost, buyClassSpeedCost;

    int classLevel;
    float classCostMultiplier;

    public GameObject[] seats;
    public int seatsUnlocked;

    public Button classLevelCount, classTimer, seatCount;

    void Start()
    {
        for (int i = 0; i < seats.Length; i++)
        {
            seats[i].SetActive(false);
        }

        seats[0].SetActive(true);
        //Need a bit clearer of a way to show 1 has been purchased and you are buying #2
        seats[1].SetActive(true);
        seatsUnlocked = 0;
    }

    void Update()
    {
        if (classLevel >= 100)
        {
            classLevelCount.GetComponent<Button>().interactable = false;
        }

        if (seatsUnlocked >= seats.Length)
        {
            seatCount.GetComponent<Button>().interactable = false;
        }
        /*
        if (seatsUnlocked >= seatCount.Length)
        {
            classTimer.GetComponent<Button>().interactable = false;
        }
        */
    }

    public void BuyClassLevel()
    {
        if (buyClassCost >= GameManager.currency)
        {
            GameManager.currency -= buyClassCost;
            classLevel++;
            buyClassCost *= (1 + classCostMultiplier);

            classLevelSlider.value = classLevel;
            classValue.text = "Lv " + classLevel;
        }
    }

    public void BuySeat()
    {
        if (buySeatCost >= GameManager.currency)
        {
            buySeatCost -= GameManager.currency;
            seatsUnlocked++;

            seats[seatsUnlocked].SetActive(true);
        }
    }

    public void BuyClassSpeed()
    {

    }
}
