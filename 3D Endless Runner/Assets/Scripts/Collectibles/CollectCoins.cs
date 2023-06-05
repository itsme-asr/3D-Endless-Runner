using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    public AudioSource coinFx;
    private void OnTriggerEnter(Collider other)
    {
        coinFx.Play();
        CollectiblesControl.coinCount += 1;
        this.gameObject.SetActive(false);
    }
}
