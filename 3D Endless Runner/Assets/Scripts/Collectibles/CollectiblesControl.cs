using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectiblesControl : MonoBehaviour
{
    public static int coinCount;
    public GameObject coinCountDisplay;
    public GameObject coinEndDisplay;
    //public GameObject coinCountDisplay;
    void Update()
    {
        coinCountDisplay.GetComponent<Text>().text = " " + coinCount;
        coinEndDisplay.GetComponent<Text>().text = " " + coinCount;

    }
}
