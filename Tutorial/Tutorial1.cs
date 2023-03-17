using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial1 : MonoBehaviour {

    public Button Next, Back, Close, tutorialClose;
    public int currentIndex = 1, maxIndex = 11;
    public Text pageNo;
    public GameObject TutorialPanel, Content1, Content2, Content3, Content4, Content5, Content6, Content7, Content8, Content9, Content10, Content11, Content12;

    private void Start()
    {
        Button nextBtn = Next.GetComponent<Button>();
        Button backBtn = Back.GetComponent<Button>();
        Button closeBtn = Close.GetComponent<Button>();
        Button tutorialCloseBtn = tutorialClose.GetComponent<Button>();

        nextBtn.onClick.AddListener(NextPage);
        backBtn.onClick.AddListener(PreviousPage);
        closeBtn.onClick.AddListener(ToggleTutorial);
        tutorialCloseBtn.onClick.AddListener(ToggleTutorial);

        Content2.SetActive(false);
        Content3.SetActive(false);
        Content4.SetActive(false);
        Content5.SetActive(false);
        Content6.SetActive(false);
        Content7.SetActive(false);
        Content8.SetActive(false);
        Content9.SetActive(false);
        Content10.SetActive(false);
        Content11.SetActive(false);
        Content12.SetActive(false);
    }

    private void NextPage()
    {
        if(currentIndex < maxIndex)
        {
            currentIndex++;
        }

        pageNo.text = currentIndex + "/" + maxIndex;
        ChangeContent(currentIndex);
    }

    private void PreviousPage()
    {
        if (currentIndex > 1)
        {
            currentIndex--;
        }

        pageNo.text = currentIndex + "/" + maxIndex;
        ChangeContent(currentIndex);
    }

    private void ToggleTutorial()
    {
        bool activeState = TutorialPanel.activeSelf;
        TutorialPanel.SetActive(!activeState);
    }

    private void ChangeContent(int currentIndex)
    {
        switch (currentIndex)
        {
            case 1:
                Content1.SetActive(true);
                Content2.SetActive(false);
                break;
            case 2:
                Content1.SetActive(false);
                Content2.SetActive(true);
                Content3.SetActive(false);
                break;
            case 3:
                Content2.SetActive(false);
                Content3.SetActive(true);
                Content4.SetActive(false);
                break;
            case 4:
                Content3.SetActive(false);
                Content4.SetActive(true);
                Content5.SetActive(false);
                break;
            case 5:
                Content4.SetActive(false);
                Content5.SetActive(true);
                Content6.SetActive(false);
                break;
            case 6:
                Content5.SetActive(false);
                Content6.SetActive(true);
                Content7.SetActive(false);
                break;
            case 7:
                Content6.SetActive(false);
                Content7.SetActive(true);
                Content8.SetActive(false);
                break;
            case 8:
                Content7.SetActive(false);
                Content8.SetActive(true);
                Content9.SetActive(false);
                break;
            case 9:
                Content8.SetActive(false);
                Content9.SetActive(true);
                Content10.SetActive(false);
                break;
            case 10:
                Content9.SetActive(false);
                Content10.SetActive(true);
                Content11.SetActive(false);
                break;
            case 11:
                Content10.SetActive(false);
                Content11.SetActive(true);
                Content12.SetActive(false);
                break;
            case 12:
                Content11.SetActive(false);
                Content12.SetActive(true);
                break;
            default:
                break;
        }
    }

    
}
