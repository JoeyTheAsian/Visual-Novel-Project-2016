﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void LoadScene(string sceneName)
    {
        //Application.LoadLevel("Scripting branched");
        SceneManager.LoadScene(sceneName);
        string nextSceneName = "UI_In Game";
        async = SceneManager.LoadSceneAsync(nextSceneName, LoadSceneMode.Additive);
        async.allowSceneActivation = true;
        //SceneManager.LoadLevelAdditive("UI_In Game");
        /*https://forum.unity3d.com/threads/scenemanager-loadscene-additive-and-set-active.380826/ */
    }
}
