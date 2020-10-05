using UnityEngine;

public class ManagerAnimals : MonoBehaviour
{
    //[SerializeField] internal GameObject referencePrefabAnimals;
    [SerializeField] internal GameObject[] prefabAnimals;
    internal Transform positionParentInstance;

    private void Awake()
    {
        positionParentInstance = transform.GetChild(0);
    }
}
