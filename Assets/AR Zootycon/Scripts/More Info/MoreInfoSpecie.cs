using UnityEngine;
using System;
using TMPro;

public class MoreInfoSpecie : MonoBehaviour
{
    [SerializeField] internal int refPositionList;
    [SerializeField] internal TextMeshProUGUI nameAnimals; 

    public void GetInfoSpecie()
    {
        InstanceManager.instance.managerSpecie.GetEvents(refPositionList);
    }
}

public static class EventsSpecie
{
    public static Action<int> getCompareScriptableAnimals;
    public static Action<int> numListPosition;
}
