using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class loadScene : MonoBehaviour {
	// http://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.LoadScene.html
	// public static void LoadScene(int sceneBuildIndex, SceneManagement.LoadSceneMode mode = LoadSceneMode.Single);
	// public static void LoadScene(string sceneName, SceneManagement.LoadSceneMode mode = LoadSceneMode.Single);

	//public Scene firstScene;
	public string firstSceneName;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void loadFirstScene(){
		SceneManager.LoadScene(firstSceneName, LoadSceneMode.Single);
	}

	public void quitGame(){
		Application.Quit();
	}
}
