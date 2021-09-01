using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
  private Text scoreText = null;
  private int oldScore = 0;

    // Start is called before the first frame update
    void Start()
    {
      scoreText = GetComponent<Text>();
      if(Gmanager.instance != null){
        scoreText.text = "SCORE:"+Gmanager.instance.score+"/100";
      }else{
        Debug.Log("forget Gamemaneger!");
        Destroy(this);
      }
    }

    // Update is called once per frame
    void Update()
    {
      if(oldScore != Gmanager.instance.score){
        scoreText.text = "SCORE:"+Gmanager.instance.score+"/100";
        oldScore = Gmanager.instance.score;
      }

    }
}
