using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gmanager : MonoBehaviour
{
  public static Gmanager instance = null;
  public int score;
  public int magazine = 50;
  public int cray = 25;
  public int geneCray = 0;

  private void Awake(){
    if(instance == null){
      instance = this;
      DontDestroyOnLoad(this.gameObject);
    }else{
      Destroy(this.gameObject);
    }
  }
}
