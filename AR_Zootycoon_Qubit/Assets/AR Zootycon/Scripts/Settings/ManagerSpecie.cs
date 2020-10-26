using UnityEngine;
using UnityEngine.UI;

public class ManagerSpecie : MonoBehaviour
{
    [SerializeField] private ManagerUI managerUI;

    [SerializeField] internal Transform positionParentAnimals;

    [Header("SETTINGS SPECIES")]
    [SerializeField] internal ScriptableManagerSpecie[] sOAnimals;

    [Header("SETTINGS PREFABS SPECIES")]
    [SerializeField] internal GameObject[] prefabAnimals;

    [Header("SCRIPTABLE OBJECTS SPECIES")]
    [SerializeField] internal GameObject[] buttonContentAnimals;

    private void Start()
    {
        EventsSpecie.getCompareScriptableAnimals += GetComparedParametersSOWithUI;
    }

    public void AddParametersTobuttonContentAnimals()
    {
        for (int i = 0; i < buttonContentAnimals.Length; i++)
        {
            buttonContentAnimals[i].GetComponentInChildren<MoreInfoSpecie>().refPositionList = sOAnimals[i].positionInList;
            buttonContentAnimals[i].GetComponent<Image>().sprite = sOAnimals[i].iconContentModel;
            buttonContentAnimals[i].GetComponentInChildren<MoreInfoSpecie>().nameAnimals.text = sOAnimals[i].nameSpecie;
        }

    }

    internal void GetComparedParametersSOWithUI(int index)
    {
        managerUI.panelInProject[4].SetActive(true);
        /*___________________________________________________________________________________________________________*/

        managerUI.nameSpecie.text = sOAnimals[index].nameSpecie;
        managerUI.iconAnimals.sprite = sOAnimals[index].iconMoreInfo;

        managerUI.descriptionAnimals.text = sOAnimals[index].descriptionSpecie;

        managerUI.isOtherSpecies = sOAnimals[index].isOtherSpecies;
        if (managerUI.isOtherSpecies)
        {
            managerUI.otherSpecie[index].sprite = sOAnimals[index].otherSpecie[index];

            for (int i = 0; i < managerUI.parentOtherSpecieAndTitle.Length; i++)
            {
                managerUI.parentOtherSpecieAndTitle[i].SetActive(true);
            }
        }
        else
        {
            for (int i = 0; i < managerUI.parentOtherSpecieAndTitle.Length; i++)
            {
                managerUI.parentOtherSpecieAndTitle[i].SetActive(false);
            }
        }

        managerUI.isStateConservationAnimals = sOAnimals[index].isStateConservationAnimals;
        if (managerUI.isStateConservationAnimals)
        {
            managerUI.iconStateConservation.sprite = sOAnimals[index].stateConservationAnimals;
            
            for (int i = 0; i < managerUI.parentStateConservationAndTitle.Length; i++)
            {
                managerUI.parentStateConservationAndTitle[i].SetActive(true);
            }
        }
        else
        {
            for (int i = 0; i < managerUI.parentStateConservationAndTitle.Length; i++)
            {
                managerUI.parentStateConservationAndTitle[i].SetActive(false);
            }
        }

        managerUI.habitAnimal.text = sOAnimals[index].habitAnimals;
        managerUI.LongevityAnimals.text = sOAnimals[index].longevityAnimals;

        managerUI.isOtherColorAnimals = sOAnimals[index].isOtherColorAnimals;
        if (managerUI.isOtherColorAnimals)
        {
            managerUI.colorAnimals[index].color = sOAnimals[index].colorRepresentativeAnimals[index];
            
            for (int i = 0; i < managerUI.parentOtherColorAnimalsAndTitle.Length; i++)
            {
                managerUI.parentOtherColorAnimalsAndTitle[i].SetActive(true);
            }
        }
        else
        {
            for (int i = 0; i < managerUI.parentOtherColorAnimalsAndTitle.Length; i++)
            {
                managerUI.parentOtherColorAnimalsAndTitle[i].SetActive(false);
            }
        }

        managerUI.isAudioAnimals = sOAnimals[index].isAudioSpecie;
        if (managerUI.isAudioAnimals)
        {
            managerUI.audioAnimals.clip = sOAnimals[index].soundSpecie;
            
            for (int i = 0; i < managerUI.parentAudioAndTitle.Length; i++)
            {
                managerUI.parentAudioAndTitle[i].SetActive(true);
            }
        }
        else
        {
            for (int i = 0; i < managerUI.parentAudioAndTitle.Length; i++)
            {
                managerUI.parentAudioAndTitle[i].SetActive(false);
            }
        }
    }

    public void GetEvents(int index)
    {
        EventsSpecie.getCompareScriptableAnimals(index);
    }
}


