using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial2 : MonoBehaviour {

    public Button Next, Back, Close, tutorialClose;
    public int currentIndex = 1, maxIndex = 3;
    public Text pageNo;
    public GameObject TutorialPanel, Content1, Content2, Content3;

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
    }

    private void NextPage()
    {
        if (currentIndex < maxIndex)
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
                break;
            default:
                break;
        }
    }
}
