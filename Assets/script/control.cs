using UnityEngine;
using System.Collections;

public class control : MonoBehaviour {
	public Julius_Client julius = null;
	public get_angle oculusrift;
	public GameObject[] obj;
	public bool main = false;
	public bool fade = false;

	public GameObject initializ_obj;
	public GameObject main_obj;

	public float value;
	public string main_command = "リンクスタート";

	private bool ready_julius = false;
	private string tmp = "";

	public string text_message = string.Empty;
	private float angle;

	private Animator anim;
	void Start() {
		anim = GetComponent<Animator>();
		angle = 360f/oculusrift.start_time;
	}

	void Update () {
		value = angle * oculusrift.timer;

		if (oculusrift.ready) {
			text_message = "Ready OculusRift";
			julius.gameObject.SetActiveRecursively (true);
			anim.SetTrigger ("julius");
			text_message = julius.message;
			if (julius.ready) {
					anim.SetTrigger ("julius_end");
					ready_julius = true;
					text_message = julius.Result;
			}
			if (julius.Result == main_command && ready_julius) {
				main_obj.gameObject.SetActiveRecursively(true);
				initializ_obj.gameObject.SetActiveRecursively(false);
				fade = true;
				main = true;
			}
		} else {
			if(value>0){
				text_message = "initialize...";
			}else{
				text_message = "Set OculusRift";
			}
		}
	}
}
