using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour {

	float rotSpeed = 0; //回転速度
	int clickNum = 0; //クリック回数

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//マウスが押されたら回転速度を設定する
		if (Input.GetMouseButtonDown (0)) {
			if (this.clickNum == 0) {
				this.rotSpeed = 40;
			}
			this.clickNum++;
		}

		//回転速度分、ルーレットを回転させる
		transform.Rotate (0, 0, this.rotSpeed);

		if (this.clickNum > 1) {
			//ルーレットを減速させる(追加)
			this.rotSpeed *= 0.97f;
		}

		if (this.rotSpeed < 0.5f) {
			//ルーレットをストップさせ、初期化する
			this.clickNum = 0;
			this.rotSpeed = 0;

		}
	}
}
