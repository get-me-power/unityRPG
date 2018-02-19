using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterModel {
	int HP;//ヒットポイント
	int MP;//マジックポイント
	int AT;//攻撃力
	int DE;//防御力
	string serifu;//会心の一撃のセリフ
	string name;//キャラの名前
	string ziseinoku;//負けた時のセリフ
	bool sleepFlg;
	bool mahiFlg;
	bool poizonFlg;
	bool[] status;//状態
	int refCount;
	bool refectFrg;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
