using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
  private Text scoreText = null;
  private int oldScore = 0;
  private int nowScore = 0;

    // Start is called before the first frame update
    void Start()
    {
      if(Gmanager.instance.magazine <=25){
        nowScore = Gmanager.instance.score + Gmanager.instance.magazine;
      }else{
        nowScore = Gmanager.instance.score;
      }

      scoreText = GetComponent<Text>();
      if(Gmanager.instance != null){
        scoreText.text = "SCORE:"+nowScore+"/100";
      }else{
        Debug.Log("forget Gamemaneger!");
        Destroy(this);
      }
    }

    // Update is called once per frame
    void Update()
    {
      if(Gmanager.instance.magazine <=25){
        nowScore = Gmanager.instance.score + Gmanager.instance.magazine;
      }else{
        nowScore = Gmanager.instance.score;
      }

      if(oldScore != nowScore){
        scoreText.text = "SCORE:"+nowScore+"/100";
        oldScore = nowScore;
      }

    }
}
