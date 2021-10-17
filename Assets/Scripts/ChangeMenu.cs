using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;



public class ChangeMenu : MonoBehaviour
{

    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void Exit()
    {
        #if UNITY_EDITOR
        EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
       
    }


}
