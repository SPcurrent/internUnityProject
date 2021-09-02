using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flushBreak : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("BreakFlush", 1.0f);
    }

    void BreakFlush(){
      Destroy(gameObject);
    }
}
