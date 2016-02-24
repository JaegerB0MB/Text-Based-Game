using UnityEngine;
using System.Collections;

public class doNotDestory : MonoBehaviour {
		
	void Awake() {
		// gameobject that has this script attached to it, will not be destory when a new level is loaded
		DontDestroyOnLoad(gameObject);
	}
}
