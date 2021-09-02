using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goStart : MonoBehaviour
{
  public void OnClickRestartButton(){
    SceneManager.LoadScene("start");
    Gmanager.instance.score = 0;
    Gmanager.instance.magazine = 50;
    Gmanager.instance.cray = 25;
    Gmanager.instance.geneCray = 0;
  }
}
