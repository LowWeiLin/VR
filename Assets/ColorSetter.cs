using UnityEngine;
using System.Collections;

public class ColorSetter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Renderer> ().material.color = new Color(0,0,0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
