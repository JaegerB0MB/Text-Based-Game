using UnityEngine;
using System.Collections;

public class UIController : MonoBehaviour {

	Canvas uiCanvas;

	// Use this for initialization
	void Start () {
		uiCanvas = gameObject.GetComponent<Canvas> ();
		uiCanvas.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			uiCanvas.enabled = !uiCanvas.enabled;
			// boolean can be either true or false;
		}
	}
}
