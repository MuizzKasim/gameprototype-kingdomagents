using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneUI : MonoBehaviour {

    public Button Level1, Level2, Level3, Level4, Level5, Back;

    private void Start()
    {
        Button lvl1Btn = Level1.GetComponent<Button>();
        Button lvl2Btn = Level2.GetComponent<Button>();
        Button lvl3Btn = Level3.GetComponent<Button>();
        Button lvl4Btn = Level4.GetComponent<Button>();
        Button lvl5Btn = Level5.GetComponent<Button>();
        Button backBtn = Back.GetComponent<Button>();

        lvl1Btn.onClick.AddListener(delegate { NavigationManager.ChangeScene("Level1"); });
        lvl2Btn.onClick.AddListener(delegate { NavigationManager.ChangeScene("Level2"); });
        lvl3Btn.onClick.AddListener(delegate { NavigationManager.ChangeScene("Level3"); });
        lvl4Btn.onClick.AddListener(delegate { NavigationManager.ChangeScene("Level4"); });
        lvl5Btn.onClick.AddListener(delegate { NavigationManager.ChangeScene("Level5"); });
        backBtn.onClick.AddListener(delegate { NavigationManager.ChangeScene("Intro"); });
    }
}
