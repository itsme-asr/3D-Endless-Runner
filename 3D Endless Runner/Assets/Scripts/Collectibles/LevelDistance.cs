using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelDistance : MonoBehaviour
{
    public GameObject distanceDisplay;
    public GameObject distanceEndDisplay;
    public int distRun;
    public bool addingDis = false;
    public float disDelay = .35f;

    private void Update()
    {
        if (addingDis == false)
        {
            addingDis = true;
            StartCoroutine(CountDistance());
        }
    }
    IEnumerator CountDistance()
    {
        distRun += 1;
        distanceDisplay.GetComponent<Text>().text = distRun + "m";
        distanceEndDisplay.GetComponent<Text>().text = distRun + "m";
        yield return new WaitForSeconds(disDelay);
        addingDis = false;
    }
}
