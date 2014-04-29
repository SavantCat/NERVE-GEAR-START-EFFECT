using UnityEngine;
using System.Collections;

public class control : MonoBehaviour {
	public Julius_Client julius = null;
	public GameObject[] obj;
	public bool main = false;
	public bool fade = false;

	public float value;
	public string main_command = "リンクスタート";

	private bool ready_julius = false;
	private string tmp = "";
	void Start() {

	}

	void Update () {
		/*
		if(tmp != julius.message){
			tmp = julius.message;
			value += 20*julius.return_num;
		}
		*/
		if(value >= 100){
			ready_julius = true;
		}
		if(julius.Result == main_command && ready_julius){
			fade = true;
			main = true;
		}
	}
}
