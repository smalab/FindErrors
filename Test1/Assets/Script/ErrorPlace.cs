using UnityEngine;
using System.Collections;

public class ErrorPlace : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		renderer.enabled = false;
	}
	
	void OnMouseEnter(){
		renderer.enabled = true;
		renderer.material.color = Color.red;
	}
	
	void OnMouseExit(){
		renderer.enabled = false;
	}
}