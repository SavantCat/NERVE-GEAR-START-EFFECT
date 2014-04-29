using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {
	public float n;
	public float r;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(r*Mathf.Cos(n),r*Mathf.Sin(n),0);
	}
}
