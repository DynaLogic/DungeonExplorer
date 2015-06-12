using UnityEngine;
using System.Collections;

public class playerscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate () {
		float horTranslate = Input.GetAxis ("Horizontal");
		float translation = Input.GetAxis ("Vertical");
		float rotate = Input.GetAxis ("Mouse X");
		float rotatevert = Input.GetAxis ("Mouse Y");
		transform.Rotate(new Vector3(rotatevert,rotate,0),Space.World);
		transform.Translate (horTranslate, 0, translation);


	}
}
