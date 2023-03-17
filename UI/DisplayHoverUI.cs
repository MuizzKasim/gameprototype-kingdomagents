using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayHoverUI : MonoBehaviour {

    public float textWidth = 250, textHeight = 150;
    public float mouseYPos = 720, newMouseYPos;
    public bool showHoverUI = false, startTimer = false;
    public float currentDelayInfo = 0f, delayInfo = 0.5f;
    public GUISkin skin;
    public CommandInfo info;

    private void Start()
    {
        newMouseYPos = mouseYPos - textHeight;
    }

    void FixedUpdate()
    {

        if (startTimer)
        {
            if (currentDelayInfo < delayInfo)
            {
                currentDelayInfo += Time.deltaTime;
            }
            else
            {
                showHoverUI = true;
            }
        }
    }

    public void setTimer(GameObject obj)
    {
        startTimer = true;
        info = obj.GetComponent<CommandInfo>();
    }

    public void ResetHoverInfo()
    {
        currentDelayInfo = 0f;
        showHoverUI = false;
        startTimer = false;
    }

    void OnGUI()
    {
        if (showHoverUI)
        {
            GUI.skin = skin;
            GUI.backgroundColor = new Color(0.9f, 0.9f, 0.9f, 0.9f);
            GUI.Box(new Rect(Input.mousePosition.x, -Input.mousePosition.y + newMouseYPos, textWidth, info.boxHeight), "Method: "+info.name+"\n\n"+ info.description+"\n\nCost: "+ info.cost+" MP");
        }
    }
}
