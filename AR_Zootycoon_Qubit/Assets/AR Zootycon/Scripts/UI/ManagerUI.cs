using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ManagerUI : MonoBehaviour
{
    [SerializeField] internal ManagerButtonsUI managerButtonsUI;
    [Space(15)]
    [SerializeField] internal GameObject[] panelInProject;
    [Space(10)]
    [SerializeField] internal GameObject panelLeftVertical;
    [SerializeField] internal GameObject imageAnimationScanner;
    [SerializeField] internal GameObject contentInfoTutorial;

    [Header("PANEL SECONDARY IN VIEW GENERAL")]
    [SerializeField] internal GameObject panelTutorialPositionateAnimals;
    [SerializeField] internal GameObject panelContentInfoAnimals;

    [Header("PANEL SOUND UI")]
    [SerializeField] internal Image iconSound;
    [SerializeField] internal Sprite[] spriteSound;

    [Header("SCRIPTABLE OBJECTS SPECIES")]
    [SerializeField] internal TextMeshProUGUI nameSpecie;
    [SerializeField] internal Image iconAnimals;
    
    [Space(15)]
    [SerializeField] internal TextMeshProUGUI descriptionAnimals;
    
    [Space(15)]
    [SerializeField] internal bool isOtherSpecies;
    [SerializeField] internal GameObject[] parentOtherSpecieAndTitle;
    [SerializeField] internal Image[] otherSpecie;

    [Space(15)]
    [SerializeField] internal bool isStateConservationAnimals;
    [SerializeField] internal GameObject[] parentStateConservationAndTitle;
    [SerializeField] internal Image iconStateConservation;

    [Space(15)]
    [SerializeField] internal TextMeshProUGUI habitAnimal;
    [SerializeField] internal TextMeshProUGUI LongevityAnimals;
    
    [Space(15)]
    [SerializeField] internal bool isOtherColorAnimals;
    [SerializeField] internal GameObject[] parentOtherColorAnimalsAndTitle;
    [SerializeField] internal Image[] colorAnimals;

    [Space(15)]
    [SerializeField] internal bool isAudioAnimals;
    [SerializeField] internal GameObject[] parentAudioAndTitle;
    [SerializeField] internal AudioSource audioAnimals;

    public void GeTAwake()
    {
        for (int i = 0; i < panelInProject.Length; i++)
        {
            panelInProject[0].SetActive(true);
            panelInProject[i].SetActive(false);
        }

        contentInfoTutorial.SetActive(true);
        panelTutorialPositionateAnimals.SetActive(false);
    }

    public void EnablePanel(int index, bool isEnablePanelDefault)
    {
        managerButtonsUI.isPanelActive = isEnablePanelDefault;

        for (int i = 0; i < panelInProject.Length; i++)
        {
            panelInProject[index].SetActive(true);
            panelInProject[1].SetActive(true);
            panelInProject[i].SetActive(false);
        }
    }

    public void DisablePanels(int index)
    {
        panelInProject[index].SetActive(false);
    }
}
