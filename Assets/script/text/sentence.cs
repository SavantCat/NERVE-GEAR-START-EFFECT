using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(TextMesh))]
[ExecuteInEditMode()]
public class sentence : MonoBehaviour {
	public float n;

	public string main;

	private TextMesh textmesh;
	// Use this for initialization
	void Start () {
		textmesh = GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {
		if (main.Length < n)
						n = (float)main.Length;
		if (n < 0)
						n = 0f;



		textmesh.text = main.Substring(0,(int)n);
	}
}
