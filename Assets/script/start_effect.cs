using UnityEngine;
using System.Collections;

public class start_effect : MonoBehaviour {
	public control control;

	public bool start = false;
	public int number = 0;
	public	float max = 100f;
	public float out_radius = 0f;
	public float in_radius = 0f;
	public	GameObject base_obj = null;
	public float speed = 1f;
	public	float move = 1000;
	public	float offset = 0f;
	public Material[] mate;

	private GameObject[] clone;
	private float pos_z = 0f;
	// Use this for initialization
	void Start () {


		if(base_obj != null){
			clone = new GameObject[number];
			float[] n = new float[number];
			float[] r = new float[number];
			float[] z = new float[number];

			for(int i = 0; i < n.Length; i++)
				n[i] = Random.Range (0f, 360f);
			
			for(int i = 0; i < r.Length; i++)
				r[i] = Random.Range (in_radius, out_radius);
		
			for(int i = 0; i < z.Length; i++)
				z[i] = Random.Range (0, max);

			for(int i = 0; i < clone.Length; i++){
				clone[i] = (GameObject)GameObject.Instantiate(base_obj);
				clone[i].transform.position = new Vector3(r[i]*Mathf.Cos(n[i]),r[i]*Mathf.Sin(n[i]),z[i] + offset) + transform.position;
				clone[i].transform.parent = transform;
				clone[i].renderer.material = mate[(int)Random.Range (0f, mate.Length)];
			}
		}
	}
	
	// Update is called once per frame
	void Update () {

		if(move > pos_z && control.main){
			pos_z += Time.deltaTime*speed;
			transform.position -= new Vector3(0,0,pos_z);
		}
	}
}
