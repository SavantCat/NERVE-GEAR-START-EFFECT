using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(LineRenderer))]
//[ExecuteInEditMode()]
public class GUI_circle_v2 : MonoBehaviour {
	public control control;
	public int segments = 100;
	public int value = 0;
	public bool offest = false;
	public float offset_angle = 0;
//	public value_test control = null;

	public bool material = true;
	public Material mate = null;

	public float timer = 0;
	public float line_width = 1.0f;
	public float radius = 1.0f;
	public Vector3[] pos;

	private float angle = 0;
   	private LineRenderer line = null;

	//public int 

	void Start ()
	{
		pos = new Vector3[segments + 1];
		for(int i = 0;i<(segments + 1);i++){
			pos[i] = Vector3.zero;
		}

		if (!offest) {
			offset_angle = segments;
		}

		angle = 360f / offset_angle;

		line = gameObject.GetComponent<LineRenderer>();
		if (material != true) {
			line.material = new Material (Shader.Find ("Particles/Additive"));
		} else if(mate != null){
			line.material = mate;
		}
		line.SetVertexCount (segments + 1);
		line.useWorldSpace = false;
		line.SetWidth(line_width ,line_width );
		CreatePoints();
		if(control == null)
			drow_circle((int)control.value);
	}
	
	void Update(){
		//drow_circle(value - Random.Range(-40, 40));
		if (control != null) {
			drow_circle ((int)control.value);
			value = (int)control.value;
		}

	}
	
	void CreatePoints()
	{
		Debug.Log ("CreatePoints");

		float tmp_angle = angle;
		for (int i = 0; i < (segments + 1); i++)
		{
			pos[i] = new Vector3(Mathf.Sin (Mathf.Deg2Rad * tmp_angle) * radius,Mathf.Cos (Mathf.Deg2Rad * tmp_angle) * radius,0);
			tmp_angle += angle; 				
		}
	}

	void drow_circle(int value){
		Debug.Log ("drow_circle");
		if(0 <= value && value < (segments + 1)){
			Debug.Log ("drow_circle->ok!");
			line.SetVertexCount(value+1);
			for (int i = 0; i < value + 1; i++)
			{
				line.SetPosition (i,pos[i]);
			}
		}
	}

}
