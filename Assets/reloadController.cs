using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reloadController : MonoBehaviour
{
    public GameObject reload;
    public GameObject reloadPos;
    public float speed = 100f;
    private int newMag;
    private int oldMag = 50;
    public AudioClip clip;

    // Update is called once per frame
    void Update()
    {
      newMag = Gmanager.instance.magazine;
      if(oldMag > newMag && (newMag % 5)==0){
        Invoke("delayGene", 0.5f);
/*
        GameObject createdReload = Instantiate(reload) as GameObject;
        createdReload.transform.position = reloadPos.transform.position;
        Vector3 force;
        force = reloadPos.transform.forward * speed;
        createdReload.GetComponent<Rigidbody>().AddForce(force);
*/
      }
      oldMag = Gmanager.instance.magazine;
    }

    private void delayGene(){
      GameObject createdReload = Instantiate(reload) as GameObject;
      createdReload.transform.position = reloadPos.transform.position;
      Vector3 force;
      force = reloadPos.transform.forward * speed;
      createdReload.GetComponent<Rigidbody>().AddForce(force);

      GetComponent<AudioSource>().PlayOneShot(clip);
    }
}
