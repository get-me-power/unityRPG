using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public Text log;

	// Use this for initialization
	void Start () {
		SetLogClean ("114514");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//ログに反映させるメソッド
	void SetLog(string txt){
		log.text = log.text + txt;
	}
    //純正なセッター
	void SetLogClean(string txt){
		log.text = txt;
	}

	void SetLogAdd(string txt){
		log.text = log.text + txt + "\n";
	}
}
