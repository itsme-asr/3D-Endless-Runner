using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public AudioSource crashFx;
    public GameObject playerM;
    public GameObject charM;
    //public GameObject cam;
    private void OnTriggerEnter(Collider other)
    {
        //coinFx.Play();
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        playerM.GetComponent<PlayerMove>().enabled = false;
        charM.GetComponent<Animator>().Play("Stumble Backwards");
        crashFx.Play();

    }

}
