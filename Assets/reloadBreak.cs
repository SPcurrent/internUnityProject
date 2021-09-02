using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reloadBreak : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("breakReload", 3.0f);
    }

    void breakReload(){
      Destroy(gameObject);
    }
}
