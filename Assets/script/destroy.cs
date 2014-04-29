using UnityEngine;
using System.Collections;

public class destroy : MonoBehaviour {
	public string tag;

	private void OnTriggerEnter(Collider other)
	{
	}
	
	private void OnTriggerStay(Collider other)
	{
	}
	
	private void OnTriggerExit(Collider collision)
	{
		Debug.Log (collision.gameObject.name);
		Destroy(gameObject);
		if (collision.gameObject.name == tag) {
			Destroy(gameObject);
		}
	}	
}
