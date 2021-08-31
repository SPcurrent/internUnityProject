using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitController : MonoBehaviour
{
  //倒したときのエフェクト
    public GameObject breakEffect;

  //当たり判定メソッド
  private void OnCollisionEnter(Collision collision)
  {
      //衝突したオブジェクトがBullet(大砲の弾)だったとき
      if(collision.gameObject.CompareTag("Bullet"))
      {
        //敵(スクリプトがアタッチされているオブジェクト自身)を削除
          Destroy(gameObject);
          //弾(引数オブジェクト)を削除
          Destroy(collision.gameObject);

          //エフェクトを発生させる
            GenerateEffect();
      }
  }

  //エフェクトを生成する
    void GenerateEffect()
    {
        //エフェクトを生成する
        GameObject effect = Instantiate(breakEffect) as GameObject;
        //エフェクトが発生する場所を決定する(敵オブジェクトの場所)
        effect.transform.position = gameObject.transform.position;
    }
}
