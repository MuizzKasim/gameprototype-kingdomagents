using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroUI : MonoBehaviour {

    public Button Begin, Quit;

    void Start()
    {
        Button beginBtn = Begin.GetComponent<Button>();
        Button quitBtn = Quit.GetComponent<Button>();
        
        beginBtn.onClick.AddListener(delegate { NavigationManager.ChangeScene("SceneSelection"); });
        quitBtn.onClick.AddListener(delegate { NavigationManager.ChangeScene("Quit"); });
    }
}
