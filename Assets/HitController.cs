using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitController : MonoBehaviour
{
  //倒したときのエフェクト
    public GameObject breakEffect;

  //スコア計測
    //public Text Scoretext;
    //private int score = 0;

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

        //スコア加算
          //score += 4;
        //テキスト反映
          //Scoretext.text = string.Format("score:{0}", score);

          //スコア加算
          Gmanager.instance.score += 4;

          //エフェクトを発生させる
            GenerateEffect();
      }
  }

  //void Update(){
    //スコア表示
    //Scoretext.text = "SCORE:" + score.ToString();
  //}

  //エフェクトを生成する
    void GenerateEffect()
    {
        //エフェクトを生成する
        GameObject effect = Instantiate(breakEffect) as GameObject;
        //エフェクトが発生する場所を決定する(敵オブジェクトの場所)
        effect.transform.position = gameObject.transform.position;
    }
}
