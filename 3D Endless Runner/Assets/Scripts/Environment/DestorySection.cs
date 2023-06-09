using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestorySection : MonoBehaviour
{
    public string parentName;
    void Update()
    {
        parentName = transform.name;
        StartCoroutine(destoryClone());

    }
    IEnumerator destoryClone()
    {
        yield return new WaitForSeconds(60);
        if (parentName == "Section(Clone)")
        {
            Destroy(gameObject);
        }
    }
}
