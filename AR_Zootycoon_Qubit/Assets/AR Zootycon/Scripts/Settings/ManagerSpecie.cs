using UnityEngine;

public class ManagerSpecie : MonoBehaviour
{
    [SerializeField] private ManagerUI managerUI;

    [SerializeField] internal Transform positionParentAnimals;

    [Header("SETTINGS SPECIES")]
    [SerializeField] internal ScriptableManagerSpecie[] sOAnimals;

    [Header("SETTINGS PREFABS SPECIES")]
    [SerializeField] internal GameObject[] prefabAnimals;

    private void Start()
    {
        EventsSpecie.getCompareScriptableAnimals += GetComparedParametersSOWithUI;
    }

    internal void GetComparedParametersSOWithUI()
    {
        managerUI.panelInProject[4].SetActive(true);

        /*___________________________________________________________________________________________________________*/

        for (int i = 0; i < managerUI.childParentInstance.Count; i++)
        {
            managerUI.nameSpecie.text = sOAnimals[managerUI.childParentInstance[i].GetComponentInChildren<MoreInfoSpecie>().refPositionList].nameSpecie;
            managerUI.iconAnimals.sprite = sOAnimals[managerUI.childParentInstance[i].GetComponentInChildren<MoreInfoSpecie>().refPositionList].iconMoreInfo;

            managerUI.descriptionAnimals.text = sOAnimals[managerUI.childParentInstance[i].GetComponentInChildren<MoreInfoSpecie>().refPositionList].descriptionSpecie;

            managerUI.isOtherSpecies = sOAnimals[managerUI.childParentInstance[i].GetComponentInChildren<MoreInfoSpecie>().refPositionList].isOtherSpecies;
            if (managerUI.isOtherSpecies)
            {
                managerUI.otherSpecie[managerUI.childParentInstance[i].GetComponentInChildren<MoreInfoSpecie>().refPositionList].sprite = 
                    sOAnimals[managerUI.childParentInstance[i].GetComponentInChildren<MoreInfoSpecie>().refPositionList].otherSpecie[managerUI.childParentInstance[i].GetComponentInChildren<MoreInfoSpecie>().refPositionList];
            }

            managerUI.isStateConservationAnimals = sOAnimals[managerUI.childParentInstance[i].GetComponentInChildren<MoreInfoSpecie>().refPositionList].isStateConservationAnimals;
            if (managerUI.isStateConservationAnimals)
            {
                managerUI.iconStateConservation.sprite = sOAnimals[managerUI.childParentInstance[i].GetComponentInChildren<MoreInfoSpecie>().refPositionList].stateConservationAnimals;
            }

            managerUI.habitAnimal.text = sOAnimals[managerUI.childParentInstance[i].GetComponentInChildren<MoreInfoSpecie>().refPositionList].habitAnimals;
            managerUI.LongevityAnimals.text = sOAnimals[managerUI.childParentInstance[i].GetComponentInChildren<MoreInfoSpecie>().refPositionList].longevityAnimals;

            managerUI.isOtherColorAnimals = sOAnimals[managerUI.childParentInstance[i].GetComponentInChildren<MoreInfoSpecie>().refPositionList].isOtherColorAnimals;
            if (managerUI.isOtherColorAnimals)
            {
                managerUI.colorAnimals[managerUI.childParentInstance[i].GetComponentInChildren<MoreInfoSpecie>().refPositionList].color = 
                    sOAnimals[managerUI.childParentInstance[i].GetComponentInChildren<MoreInfoSpecie>().refPositionList].colorRepresentativeAnimals[managerUI.childParentInstance[i].GetComponentInChildren<MoreInfoSpecie>().refPositionList];
            }

            managerUI.isAudioAnimals = sOAnimals[managerUI.childParentInstance[i].GetComponentInChildren<MoreInfoSpecie>().refPositionList].isAudioSpecie;
            if (managerUI.isAudioAnimals)
            {
                managerUI.audioAnimals.clip = sOAnimals[managerUI.childParentInstance[i].GetComponentInChildren<MoreInfoSpecie>().refPositionList].soundSpecie;
            }
        }

    }

    public void GetEvents()
    {
        EventsSpecie.getCompareScriptableAnimals();
    }
}


