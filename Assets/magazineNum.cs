using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class magazineNum : MonoBehaviour
{
  private Text magazineText = null;
  private int oldMagazine = 50;

    // Start is called before the first frame update
    void Start()
    {
      magazineText = GetComponent<Text>();
      if(Gmanager.instance != null){
        magazineText.text = Gmanager.instance.magazine+"/50";
      }else{
        Debug.Log("forget GameManager!");
        Destroy(this);
      }
    }

    // Update is called once per frame
    void Update()
    {
      if(oldMagazine != Gmanager.instance.magazine){
        magazineText.text = Gmanager.instance.magazine+"/50";
        oldMagazine = Gmanager.instance.magazine;
      }
    }
}
