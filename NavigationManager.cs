using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigationManager : MonoBehaviour {

    public static void ChangeScene(string destination)
    {
        if (destination == "Quit")
        {
            Debug.Log("NavigationManager: Quitting");
            Application.Quit();
        }
        else
        {
            Debug.Log("NavigationManager: LoadScene("+destination+")");
            SceneManager.LoadScene(destination);
        }
    }
}
