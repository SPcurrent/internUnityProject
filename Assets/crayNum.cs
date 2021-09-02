using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class crayNum : MonoBehaviour
{
  private Text crayText = null;
  private int oldCray = 25;

    // Start is called before the first frame update
    void Start()
    {
      crayText = GetComponent<Text>();
      if(Gmanager.instance != null){
        crayText.text = Gmanager.instance.cray+"/25";
      }else{
        Debug.Log("forget GameManager!");
        Destroy(this);
      }
    }

    // Update is called once per frame
    void Update()
    {
      if(oldCray != Gmanager.instance.cray){
        crayText.text = Gmanager.instance.cray+"/25";
        oldCray = Gmanager.instance.cray;
      }
      if(Gmanager.instance.cray == 0){
        Invoke("GotoResult", 2.0f);

      }
    }

    void GotoResult(){
      SceneManager.LoadScene("result");
    }
}
