using UnityEngine;
using System.Collections;

public class eye_logo : MonoBehaviour {
	public GameObject eye;
	public GUI_circle_v2 gui;
	// Use this for initialization
	void Start () {
		eye.gameObject.SetActiveRecursively(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (gui.value > 0f) {
			eye.gameObject.SetActiveRecursively (true);
		} else {
			eye.gameObject.SetActiveRecursively (false);
		}
	}
}
