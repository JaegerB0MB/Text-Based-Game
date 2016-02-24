using UnityEngine;
using System.Collections;

public class healthModifier : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			StatsManager.health++;
			Debug.Log(StatsManager.health);
		}
	}

}
