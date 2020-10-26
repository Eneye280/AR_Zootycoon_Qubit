using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

public class MoreInfoSpecie : MonoBehaviour
{
    [SerializeField] internal Button buttonMoreInfo;
    public int refPositionList;

    private void Start()
    {
        buttonMoreInfo = GetComponent<Button>();
        buttonMoreInfo.onClick.AddListener(GetInfoSpecie);


        //AQUI QUEDE (debe comparar el numero para que se adapte a la lista, de 0 a 5 )

        //for (int i = 0; i < InstanceManager.instance.managerUI.childParentInstance.Count; i++)
        //{
        //    InstanceManager.instance.managerUI.childParentInstance.
        //}
        refPositionList = InstanceManager.instance.managerSpecie.sOAnimals.Count();
    }

    public void GetInfoSpecie()
    {
        Debug.Log("Press the button " + buttonMoreInfo.name);
        InstanceManager.instance.managerSpecie.GetEvents();
    }
}
public static class EventsSpecie
{
    public static Action getCompareScriptableAnimals;
}
