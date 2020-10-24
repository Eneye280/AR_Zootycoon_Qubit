using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableContentSpecie", menuName = "ScriptableObjects/AddContentSpecie")]
public class ScriptableContentSpecie : ScriptableObject
{
    public List<GameObject> prefabAnimals;
    public List<GameObject> prefabPlants;
}
