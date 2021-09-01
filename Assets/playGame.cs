using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playGame : MonoBehaviour
{
  private bool firstPush = false;

     public void PressStart()
     {
          if (!firstPush)
          {
              //ここに次のシーンへいく命令を書く
              SceneManager.LoadScene("Game");
              //
              firstPush = true;
          }
     }
}
