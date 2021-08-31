using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBreak : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("BreakEnemy", 6.0f);
    }

    void BreakEnemy(){
      Destroy(gameObject);
    }
}
