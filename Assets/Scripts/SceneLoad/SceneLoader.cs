using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.EventSystems;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public GameSceneSO newGameSceneLoad;
    public GameSceneSO mainScene;

    public float fadeDuration = 2;
    
    public void SceneChange()
    {
        StartCoroutine(UnLoadPreviousScene());
    }

    private IEnumerator UnLoadPreviousScene()
    {
        yield return new WaitForSeconds(fadeDuration);

        Debug.Log("this1");
        
        yield return mainScene.sceneReference.UnLoadScene();
        Debug.Log("this2");
        LoadNewScene();
    }

    private void LoadNewScene()
    {
        newGameSceneLoad.sceneReference.LoadSceneAsync(LoadSceneMode.Additive, true);
    }


}
