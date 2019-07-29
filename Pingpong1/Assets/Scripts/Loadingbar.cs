﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadingbar : MonoBehaviour
{
    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronosously(sceneIndex));
    }

    IEnumerator LoadAsynchronosously (int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress/ .9f);
            Debug.Log("progress");
            yield return null;
        }

    }
}
