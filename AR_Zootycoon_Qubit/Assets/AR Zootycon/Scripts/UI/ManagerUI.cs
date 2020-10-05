using System.Collections;
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

    [Header("SETTINGS PANEL SECONDARY IN VIEW GENERAL")]
    [SerializeField] internal GameObject panelTutorialPositionateAnimals;
    [SerializeField] internal GameObject panelContentInfoAnimals;

    [Header("SETTINGS SO ANIMALS")]
    [SerializeField] internal SOAnimals[] sOAnimals;
    [Space(10)]
    [SerializeField] internal Image iconAnimals;
    [SerializeField] internal TextMeshProUGUI descriptionAnimals;
    [Space(3)]
    [SerializeField] internal Image[] colorAnimals;
    [SerializeField] internal TextMeshProUGUI habitAnimal;
    [Space(3)]
    [SerializeField] internal Image[] otherSpecieAnimal;

    private WaitForSeconds delayStopPanelViewGame = new WaitForSeconds(1f);

    private void Start()
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
