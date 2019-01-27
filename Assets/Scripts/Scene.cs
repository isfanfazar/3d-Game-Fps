using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour {

	public string EnterS;
	public string QuitS;
	public bool isEscapeForQuit = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.Return))
		{
			Debug.Log("Name Scene: " + EnterS);
			SceneManager.LoadScene(EnterS);
		}
		
		if (Input.GetKeyUp(KeyCode.Escape))
		{
			if (isEscapeForQuit)
			{
				Application.Quit();
			}
			else 
			{
				Debug.Log("Name Scene: " + QuitS);
				SceneManager.LoadScene(QuitS);
			}
		}
	}
}
