using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public AudioSource crashFx;
    public GameObject playerM;
    public GameObject charM;
    public GameObject cam;
    public GameObject levelControl;
    //public GameObject cam;
    private void OnTriggerEnter(Collider other)
    {
        //coinFx.Play();
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        playerM.GetComponent<PlayerMove>().enabled = false;
        charM.GetComponent<Animator>().Play("Stumble Backwards");
        levelControl.GetComponent<LevelDistance>().enabled = false;
        crashFx.Play();
        cam.GetComponent<Animator>().enabled = true;
        levelControl.GetComponent<EndRunSequence>().enabled = true;

    }

}
