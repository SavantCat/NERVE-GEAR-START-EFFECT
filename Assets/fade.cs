using UnityEngine;
using System.Collections;

public class fade : MonoBehaviour {
	public Texture2D texture;
	public float alpha = 1;
	public float offset = 1;
	public	Color color;
	// Use this for initialization
	void  Awake() {
		texture = new Texture2D( 1, 1, TextureFormat.ARGB32,false);
		texture.SetPixel(0,0,Color.white);
		texture.Apply();
		color = new Color (0, 0, 0, alpha);
	}
	
	// Update is called once per frame
	void Update () {
		if(alpha >= 0){
			alpha -= Time.deltaTime*offset;
		}
		color = new Color (0, 0, 0, alpha);
	}

	void OnGUI()
	{
		GUI.color = color;
		GUI.DrawTexture(new Rect( 0, 0, Screen.width, Screen.height ), texture );
	}
}
