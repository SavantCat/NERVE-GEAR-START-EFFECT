using UnityEngine;
using System.Collections;

public class get_angle : MonoBehaviour {

	public GameObject oculusrift;

	public Vector3 angle = Vector3.zero;
	public bool ready = false;

	public float max = 0f;
	public float min = 0f;

	public float timer = 0f;
	public float start_time = 0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		angle = oculusrift.transform.eulerAngles;

		if (ready == false && min < angle.x && angle.x < max) {
			if(timer <= start_time){
				timer += Time.deltaTime;
				if (timer >= start_time){
						ready = true;
						timer = 0;
				}
			}
		} else if (ready == true && max < angle.x) {
			if(timer <= start_time){
				timer += Time.deltaTime;
				if (timer >= start_time){
					ready = false;
					timer = 0;
				}
			}
		} else {
			timer = 0f;
			//ready = true;
		}

	}
}
