using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gmanager : MonoBehaviour
{
  public static Gmanager instance = null;
  public int score;
  public int magazine = 50;
  public int bullet = 0;
  public int cray = 25;
  public int geneCray = 0;
  public AudioSource audioSource = null;

  private void Awake(){
    if(instance == null){
      instance = this;
      DontDestroyOnLoad(this.gameObject);
    }else{
      Destroy(this.gameObject);
    }
  }
/*
  public void PlaySE(AudioClip clip){
    if(audioSource != null){
      audioSource.PlayOneShot(clip);
    }else{
      Debug.Log("no AudioSource");
    }
  }*/
}
