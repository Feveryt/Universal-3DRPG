using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.EventSystems;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

public class MainSceneLoader : MonoBehaviour
{


    public GameSceneSO mainScene;


    private void Awake()
    {
        mainScene.sceneReference.LoadSceneAsync(LoadSceneMode.Additive, true);
    }
}
    
