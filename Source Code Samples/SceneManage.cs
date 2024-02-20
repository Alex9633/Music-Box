using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(LoadAsync());
    }

    IEnumerator LoadAsync()
    {
        yield return null;
        SceneManager.LoadSceneAsync("[next scene]");
        yield return new WaitForEndOfFrame();
    }
}
