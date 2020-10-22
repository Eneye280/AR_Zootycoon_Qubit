using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Animal", menuName = "SOAnimals")]
public class SOSpecie : ScriptableObject
{
    [SerializeField] internal bool isAnimals;
    [SerializeField] internal bool isPlant;

    [Header("SETTING GENERAL")]
    [SerializeField] internal string nameSpecie;

    [SerializeField] internal Sprite iconContentModel;
    [SerializeField] internal Sprite iconMoreInfo;

    [Space(15)]
    [TextArea(0, 800)]
    [SerializeField] internal string descriptionSpecie;

    [Space(15)]
    [SerializeField] internal bool isOtherSpecies;
    [SerializeField] internal Sprite[] otherSpecie;

    [Space(15)]
    public List<Animals> animals;
    public List<Plants> plants;
}

[System.Serializable]
public class Animals
{
    [SerializeField] internal bool isStateConservation;
    [SerializeField] internal Sprite stateConservation;

    [Space(15)]
    [TextArea(0, 20)]
    [SerializeField] internal string habitSpecie;
    [TextArea(0, 20)]
    [SerializeField] internal string longevitySpecie;

    [Space(15)]
    [SerializeField] internal bool isOtherColor;
    [SerializeField] internal Color[] colorRepresentative;

    [Space(15)]
    [SerializeField] internal bool isAudioSpecie;
    [SerializeField] internal AudioClip soundSpecie;
}

[System.Serializable]
public class Plants
{
    [TextArea(0, 20)]
    [SerializeField] internal string habitSpecie;
    [TextArea(0, 20)]
    [SerializeField] internal string longevitySpecie;

    [Space(15)]
    [SerializeField] internal bool isOtherColor;
    [SerializeField] internal Color[] colorRepresentative;
}
