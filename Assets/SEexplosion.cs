using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEexplosion : MonoBehaviour
{
  public AudioClip clip1;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().PlayOneShot(clip1);
    }

    // Update is called once per frame
    //void Update()
    //{

    //}
}
