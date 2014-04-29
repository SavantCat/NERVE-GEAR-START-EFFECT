using UnityEngine;
using System.Collections;
using System;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(TextMesh))]
[RequireComponent(typeof(AudioSource))]
[ExecuteInEditMode()]
public class NowTime : MonoBehaviour {
	private TextMesh gui_text = null;
	public Font gui_font = null;
	public int font_size = 0;

	public bool Sound_Effect = false;
	public AudioClip audio_data = null;
	private AudioSource main_audio = null;
	// Use this for initialization
	void Start () {
		gui_text = GetComponent<TextMesh>();
		gui_text.font = gui_font;
		gui_text.fontSize = font_size;
		gui_text.text = "00:00";
		if(Sound_Effect){
			main_audio = GetComponent<AudioSource>();
			if(audio_data != null && main_audio != null){
				main_audio.clip = audio_data;
			}
		}
	}
	
	// Update is called once per frame
	void Update(){
		if(DateTime.Now.Second % 2 == 0){
			gui_text.text = DateTime.Now.ToString("HH:mm");
		}else{
			gui_text.text = DateTime.Now.ToString("HH mm");
			if(Sound_Effect){
				if(audio_data != null && main_audio != null){
					main_audio.Play();
				}
			}
		}

	}
}
