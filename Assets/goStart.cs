using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goStart : MonoBehaviour
{
  public void OnClickRestartButton(){
    SceneManager.LoadScene("start");
  }
}
