using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Smoothload : MonoBehaviour
{

    public void LoadByIndex(string sceneIndex)
    {
        SceneManager.LoadSceneAsync(sceneIndex);
    }
}