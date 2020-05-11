using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapLocationsBtn : MonoBehaviour
{
    public int sceneIndex;

    public void LoadScene()
    {
        Invoke("LoadSceneDelayed", 4.0f);
    }

    private void LoadSceneDelayed()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
