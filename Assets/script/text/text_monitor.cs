using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(TextMesh))]
[ExecuteInEditMode()]
public class text_monitor : MonoBehaviour {
	public control control;

	public int n = 1;
	public string[] str;

	private int i = 1;
	private int num = 0;
	private string tmp;
	private TextMesh textmesh;
	// Use this for initialization
	void Start () {
		textmesh = GetComponent<TextMesh>();
		str = new string[n];
		for(int i=0;i<str.Length;i++){
			str[i] = "\n";

			//textmesh.text += str[i];
		}
		str [0] = "\n";
	}
	
	// Update is called once per frame
	void Update () {
		tmp = control.julius.message + "\n";
		Debug.Log(transform.name + ":" + tmp);
		if(tmp != str[i-1]){
			str[i++] =tmp;
		}

		if(i >= str.Length){
			i = 1;
		}

		textmesh.text = string.Empty;
		for(int j=0;j<str.Length;j++){
			textmesh.text += str[j];
		}
	}
}
