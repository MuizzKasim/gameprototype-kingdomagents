using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

    public Button Forward, turnLeft, turnRight, switchKnight, switchMage, switchNinja, Run, Activate, loop2Start, loopEnd, Dropdown, Grid, Menu, menuClose, Slow, Normal, Fast, mainMenu, Quit, Yes, No, Ok;
    public GameObject grid,dropdownPanel, menuPanel, confirmPanel, scorePanel;
    public GameObject forwardPrefab, turnLeftPrefab, turnRightPrefab, switchKnightPrefab, switchMagePrefab,switchNinjaPrefab, activatePrefab, loop2StartPrefab, loopEndPrefab;
    public Transform parentNew;
    public float xPosBase = 62, xPosMultiplier = -1, xPosNew = 0, xPosLeftMost = -353f;
    public string sceneClicked;
    
    void Start () {
        //old buttons
        Button forwardBtn = Forward.GetComponent<Button>();
        Button turnLeftBtn = turnLeft.GetComponent<Button>();
        Button turnRightBtn = turnRight.GetComponent<Button>();
        Button runBtn = Run.GetComponent<Button>();

        //new buttons
        Button switchKnightBtn = switchKnight.GetComponent<Button>();
        Button switchNinjaBtn = switchNinja.GetComponent<Button>();
        Button switchMageBtn = switchMage.GetComponent<Button>();
        Button activateBtn = Activate.GetComponent<Button>();
        Button dropdownBtn = Dropdown.GetComponent<Button>();
        Button gridBtn = Grid.GetComponent<Button>();
        Button menuBtn = Menu.GetComponent<Button>();
        Button slowBtn = Slow.GetComponent<Button>();
        Button normalBtn = Normal.GetComponent<Button>();
        Button fastBtn = Fast.GetComponent<Button>();
        Button mainMenuBtn = mainMenu.GetComponent<Button>();
        Button menuCloseBtn = menuClose.GetComponent<Button>();
        Button quitBtn = Quit.GetComponent<Button>();
        Button yesBtn = Yes.GetComponent<Button>();
        Button noBtn = No.GetComponent<Button>();
        Button okBtn = Ok.GetComponent<Button>();
        Button loop2StartBtn = loop2Start.GetComponent<Button>();
        Button loopEndBtn = loopEnd.GetComponent<Button>();

        //old listeners
        forwardBtn.onClick.AddListener(Goforward);
        turnLeftBtn.onClick.AddListener(TurnLeft);
        turnRightBtn.onClick.AddListener(TurnRight);
        runBtn.onClick.AddListener(CommandButton);

        //new listeners
        switchKnightBtn.onClick.AddListener(delegate { ChangeCharacter("Knight"); });
        switchMageBtn.onClick.AddListener(delegate { ChangeCharacter("Mage"); });
        switchNinjaBtn.onClick.AddListener(delegate { ChangeCharacter("Ninja"); });
        activateBtn.onClick.AddListener(ActivateAbility);
        dropdownBtn.onClick.AddListener(ToggleDropdownPanel);
        gridBtn.onClick.AddListener(ToggleGrid);
        menuBtn.onClick.AddListener(ToggleMenu);
        slowBtn.onClick.AddListener(SetSpeedSlow);
        normalBtn.onClick.AddListener(SetSpeedNormal);
        fastBtn.onClick.AddListener(SetSpeedFast);
        mainMenuBtn.onClick.AddListener(delegate { ToggleReconfirm("Intro"); });
        menuCloseBtn.onClick.AddListener(ToggleMenu);
        quitBtn.onClick.AddListener(delegate { ToggleReconfirm("Quit"); });
        yesBtn.onClick.AddListener(ConfrimSelection);
        noBtn.onClick.AddListener(delegate { ToggleReconfirm(sceneClicked); });
        okBtn.onClick.AddListener(ToggleScore);
        loop2StartBtn.onClick.AddListener(Loop2Start);
        loopEndBtn.onClick.AddListener(LoopEnd);

        //GameObjects
        grid.SetActive(false);
        dropdownPanel.SetActive(false);
        menuPanel.SetActive(false);
        confirmPanel.SetActive(false);
        scorePanel.SetActive(true);

        //color
        Dropdown.GetComponent<Image>().color = Color.black;
        Slow.GetComponent<Image>().color = Color.white;
        Normal.GetComponent<Image>().color = Color.black;
        Fast.GetComponent<Image>().color = Color.black;
    }
	
	void Update () {

	}

    //command methods
    private void Goforward()
    {
        Debug.Log("Goforward()");

        DisplayCommand("forward");
    }

    private void TurnLeft()
    {
        Debug.Log("TurnLeft()");

        DisplayCommand("turnLeft");

    }

    private void TurnRight()
    {
        Debug.Log("TurnRight()");

        DisplayCommand("turnRight");

    }

    private void ChangeCharacter(string character)
    {
        Debug.Log("ChangeCharacter()");

        if (character.Equals("Knight"))
        {
            DisplayCommand("switchKnight");
        }
        else if (character.Equals("Mage"))
        {
            DisplayCommand("switchMage");
        }
        else if (character.Equals("Ninja"))
        {
            DisplayCommand("switchNinja");
        }

    }

    private void CommandButton()
    {
        Debug.Log("CommandButton()");


    }

    private void ActivateAbility()
    {
        Debug.Log("ActivateAbility()");

        DisplayCommand("activateAbility");

    }

    private void Loop2Start()
    {
        Debug.Log("Loop2Start()");

        DisplayCommand("loop2Start");
    }

    private void LoopEnd()
    {
        Debug.Log("LoopEnd");

        DisplayCommand("loopEnd");
    }

    //new
    private void DisplayCommand(string command)
    {
        xPosMultiplier++; xPosNew = xPosBase * xPosMultiplier;

        Debug.Log("xPosBase: " + xPosBase + " , xPosMultiplier: " + xPosMultiplier + " , xPosNew: " + xPosNew);

        if (command.Equals("forward"))
        {
            GameObject commandDiplay = Instantiate(forwardPrefab, new Vector3(xPosLeftMost + xPosNew, 34f, 0f), transform.rotation) as GameObject;
            commandDiplay.transform.SetParent(parentNew, false);
        }
        if (command.Equals("turnLeft"))
        {
            GameObject commandDiplay = Instantiate(turnLeftPrefab, new Vector3(xPosLeftMost + xPosNew, 34f, 0f), transform.rotation) as GameObject;
            commandDiplay.transform.SetParent(parentNew, false);
        }
        if (command.Equals("turnRight"))
        {
            GameObject commandDiplay = Instantiate(turnRightPrefab, new Vector3(xPosLeftMost + xPosNew, 34f, 0f), transform.rotation) as GameObject;
            commandDiplay.transform.SetParent(parentNew, false);
        }
        if (command.Equals("switchKnight"))
        {
            GameObject commandDiplay = Instantiate(switchKnightPrefab, new Vector3(xPosLeftMost + xPosNew, 34f, 0f), transform.rotation) as GameObject;
            commandDiplay.transform.SetParent(parentNew, false);
        }
        if (command.Equals("switchMage"))
        {
            GameObject commandDiplay = Instantiate(switchMagePrefab, new Vector3(xPosLeftMost + xPosNew, 34f, 0f), transform.rotation) as GameObject;
            commandDiplay.transform.SetParent(parentNew, false);
        }
        if (command.Equals("switchNinja"))
        {
            GameObject commandDiplay = Instantiate(switchNinjaPrefab, new Vector3(xPosLeftMost + xPosNew, 34f, 0f), transform.rotation) as GameObject;
            commandDiplay.transform.SetParent(parentNew, false);
        }
        if (command.Equals("activateAbility"))
        {
            GameObject commandDiplay = Instantiate(activatePrefab, new Vector3(xPosLeftMost + xPosNew, 34f, 0f), transform.rotation) as GameObject;
            commandDiplay.transform.SetParent(parentNew, false);
        }
        if (command.Equals("loop2Start"))
        {
            GameObject commandDiplay = Instantiate(loop2StartPrefab, new Vector3(xPosLeftMost + xPosNew, 34f, 0f), transform.rotation) as GameObject;
            commandDiplay.transform.SetParent(parentNew, false);
        }
        if (command.Equals("loopEnd"))
        {
            GameObject commandDiplay = Instantiate(loopEndPrefab, new Vector3(xPosLeftMost + xPosNew, 34f, 0f), transform.rotation) as GameObject;
            commandDiplay.transform.SetParent(parentNew, false);
        }


    }

    public void RemoveCommand()
    {
        xPosMultiplier--;
    }

    private void ToggleDropdownPanel()
    {
        bool activeState = dropdownPanel.activeSelf;
        dropdownPanel.SetActive(!activeState);

        if (activeState)
        {
            Dropdown.GetComponent<Image>().color = Color.black;
        }
        else
        {
            Dropdown.GetComponent<Image>().color = Color.white;
        }
    }

    private void ToggleGrid()
    {
        bool activeState = grid.activeSelf;
        grid.SetActive(!activeState);
    }

    private void ToggleMenu()
    {
        bool activeState = menuPanel.activeSelf;
        menuPanel.SetActive(!activeState);
    }

    private void ToggleScore()
    {
        bool activeState = scorePanel.activeSelf;
        scorePanel.SetActive(!activeState);
    }

    private void ToggleReconfirm(string sceneClicked)
    {
        bool activeState = confirmPanel.activeSelf;
        confirmPanel.SetActive(!activeState);
        this.sceneClicked = sceneClicked;
        
    }

    private void ConfrimSelection()
    {
        NavigationManager.ChangeScene(sceneClicked);
    }
    
    private void SetSpeedSlow()
    {
        Slow.GetComponent<Image>().color = Color.white;
        Normal.GetComponent<Image>().color = Color.black;
        Fast.GetComponent<Image>().color = Color.black;
    }

    private void SetSpeedNormal()
    {
        Slow.GetComponent<Image>().color = Color.black;
        Normal.GetComponent<Image>().color = Color.white;
        Fast.GetComponent<Image>().color = Color.black;
    }

    private void SetSpeedFast()
    {
        Slow.GetComponent<Image>().color = Color.black;
        Normal.GetComponent<Image>().color = Color.black;
        Fast.GetComponent<Image>().color = Color.white;
    }
}
