using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletBreak : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("BreakBullet",4.0f);
    }

    void BreakBullet(){
      Destroy(gameObject);
    }
}
