using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    public GameObject countD3;
    public GameObject countD2;
    public GameObject countD1;
    public GameObject countGO;
    public GameObject fadeIn;
    public AudioSource readyFx;
    public AudioSource GoFx;

    private void Start()
    {
        StartCoroutine(count());
    }

    IEnumerator count()
    {
        yield return new WaitForSeconds(1.5f);
        countD3.SetActive(true);
        readyFx.Play();
        yield return new WaitForSeconds(1f);
        countD2.SetActive(true);
        readyFx.Play();
        yield return new WaitForSeconds(1f);
        countD1.SetActive(true);
        readyFx.Play();
        yield return new WaitForSeconds(1f);
        countGO.SetActive(true);
        GoFx.Play();
        PlayerMove.canMove = true;
    }


}
