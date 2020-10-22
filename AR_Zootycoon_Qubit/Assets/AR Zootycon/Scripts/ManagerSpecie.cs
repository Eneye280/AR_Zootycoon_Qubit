using UnityEngine;

public class ManagerSpecie : MonoBehaviour
{
    internal Transform positionParentInstance;
        
    [Header("SETTINGS SPECIES")]
    [SerializeField] internal SOSpecie[] sOAnimals;
    [SerializeField] internal SOSpecie[] sOPlants;

    [Header("SETTINGS PREFABS SPECIES")]
    [SerializeField] internal GameObject[] prefabAnimals;
    [SerializeField] internal GameObject[] prefabPlants;

    private void Awake()
    {
        positionParentInstance = transform.GetChild(0);
    }
}
