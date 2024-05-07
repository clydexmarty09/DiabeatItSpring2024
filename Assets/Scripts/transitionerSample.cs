/*//this is an example file 
using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using UnityEngine.SceneManagement; 

public class SceneLoader : MonoBehaviour {
public SceneTransition transitioner; // SceneTransition already defined
public string sceneNameToLoad; 

	void start() {
		// implement this ; ie: transitioner.LoadScene(//scene name here)
	}


} // end class 

/*
using System.Collections; 
using System.Collenctions.Generic; 
using UnityEngine; 
using UnityEngine.SceneManagement; 

public class SceneLoader: MonoBehaviour 
{
	public SceneTransition transitioner; 
	public string[] scenes; 
	public int currentSceneIndex = 0; 

	public void LoadNextScene()
	{
		if (currentSceneIndex < scenes.length) {
			transitioner.LoadScene(scenes	
		}
	
	}


}
*/
