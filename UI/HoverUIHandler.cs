using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverUIHandler : MonoBehaviour {

    public bool showHoverUI, startTimer;
    public float currentDelayInfo = 0f, delayInfo = 0.1f;

    void FixedUpdate()
    {

        if (startTimer)
        {
            if (currentDelayInfo < delayInfo)
            {
                currentDelayInfo += Time.deltaTime;
                Debug.Log(currentDelayInfo);
            }
        }
    }

    private void OnMouseEnter()
    {
        startTimer = true;
        Debug.Log("Entered");

        if (currentDelayInfo == delayInfo)
        {
            showHoverUI = true;
            Debug.Log(showHoverUI);
        }

    }

    private void OnMouseExit()
    {
        showHoverUI = false;
        startTimer = false;
        currentDelayInfo = 0f;
        Debug.Log(showHoverUI + " , " + startTimer + " , " + currentDelayInfo);
    }
}
