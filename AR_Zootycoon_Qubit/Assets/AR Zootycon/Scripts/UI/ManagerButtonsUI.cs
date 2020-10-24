﻿using UnityEngine;

public class ManagerButtonsUI : MonoBehaviour
{
    [SerializeField] internal ManagerUI managerUI;

    [Header("BUTTON TUTORIAL")]
    [SerializeField] internal bool isButtonTutorial;

    [Header("OPEN PANEL LEFT")]
    [SerializeField] internal bool isPanelActive;
    [SerializeField] internal Animator animPanelLeft;

    public void OpenPanelLeftAnimation()
    {
        isPanelActive = !isPanelActive;

        switch (isPanelActive)
        {
            case true:
                animPanelLeft.SetBool("isPanelActive", true);
                managerUI.contentInfoTutorial.SetActive(false);
                isButtonTutorial = false;
                break;
            case false:
                animPanelLeft.SetBool("isPanelActive", false);
                break;
        }
    }
    public void OpenPanelHouse()
    {
        managerUI.EnablePanel(0, false);
        managerUI.panelInProject[1].SetActive(false);
        managerUI.contentInfoTutorial.SetActive(false);
        managerUI.imageAnimationScanner.SetActive(false);
        managerUI.panelContentInfoAnimals.SetActive(false);
        isButtonTutorial = false;
    }
    public void OpenPanelContentModel()
    {
        InstanceManager.instance.isEnableInstance = false;
        managerUI.EnablePanel(2, false);
        isButtonTutorial = false;
    }
    public void OpenPanelFavorite()
    {
        managerUI.EnablePanel(3, false);
        isButtonTutorial = false;
    }
    public void OpenPanelSettings()
    {
        managerUI.EnablePanel(5, false);
        isButtonTutorial = false;
    } 
    public void OpenContentMoreInfo()
    {
        managerUI.EnablePanel(4, false);
        isButtonTutorial = false;
    }

    public void ButtonOnOffTutorial()
    {
        isButtonTutorial = !isButtonTutorial;

        isPanelActive = false;
        animPanelLeft.SetBool("isPanelActive", false);

        switch (isButtonTutorial)
        {
            case true:
                managerUI.contentInfoTutorial.SetActive(true);
                break;
            case false:
                managerUI.contentInfoTutorial.SetActive(false);
                break;
        }
    }
    public void ButtonNextToPanelView()
    {
        managerUI.EnablePanel(1, false);
        managerUI.contentInfoTutorial.SetActive(true);
    }
}
