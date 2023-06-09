using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateLevels : MonoBehaviour
{
    [SerializeField] private GameObject[] section;
    public int zPos = 50;
    public bool creatingSection = false;
    public int secNum;

    private void Update()
    {
        if (creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(generateSection());
        }
    }

    IEnumerator generateSection()
    {
        secNum = Random.Range(0, 3);
        Instantiate(section[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 50;
        yield return new WaitForSeconds(6.5f);
        creatingSection = false;
    }
}
