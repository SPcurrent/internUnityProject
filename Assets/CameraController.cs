using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraController:MonoBehaviour{

  // Start is called before the first frame update
//  void Start(){
    [Range(0f, 1f)] public float rotationSpeed = 1f;
    [Range(0f, 90f)] public float max_rotation_x = 80f;
    [Range(0f, 90f)] public float min_rotation_x = 80f;
    [Range(0f, 180f)] public float max_rotation_y = 180f;
    private float rotation_x = 0f;
    private float rotation_y = 0f;
//  }

  // Update is called once per frame
  void Update(){

    if(Input.GetKey(KeyCode.LeftArrow)){
      if(rotation_y < -max_rotation_y){
        return;
       }
      rotation_y -= rotationSpeed;
      transform.rotation = Quaternion.Euler(rotation_x, rotation_y, 0);
    }else if(Input.GetKey(KeyCode.RightArrow)){
      if(rotation_y > max_rotation_y){
        return;
      }
      rotation_y += rotationSpeed;
      transform.rotation = Quaternion.Euler(rotation_x, rotation_y, 0);
    }

    if(Input.GetKey(KeyCode.UpArrow)){
      if(rotation_x < -max_rotation_x){
        return;
      }
      rotation_x -= rotationSpeed;
      transform.rotation = Quaternion.Euler(rotation_x, rotation_y, 0);
    }else if(Input.GetKey(KeyCode.DownArrow)){
      if(rotation_x > min_rotation_x){
        return;
      }
      rotation_x += rotationSpeed;
      transform.rotation = Quaternion.Euler(rotation_x, rotation_y, 0);
    }

  }

}
