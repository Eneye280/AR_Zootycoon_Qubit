using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Animal", menuName = "ScriptableObjects/SOAnimals")]
public class ScriptableManagerSpecie : ScriptableObject
{
    [SerializeField] internal int positionInList;

    [Space(15)]
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


    [Header("SETTINGS ANIMALS")]
    [SerializeField] internal bool isStateConservationAnimals;
    [SerializeField] internal Sprite stateConservationAnimals;

    [Space(15)]
    [TextArea(0, 20)]
    [SerializeField] internal string habitAnimals;
    [TextArea(0, 20)]
    [SerializeField] internal string longevityAnimals;

    [Space(15)]
    [SerializeField] internal bool isOtherColorAnimals;
    [SerializeField] internal Color[] colorRepresentativeAnimals;

    [Space(15)]
    [SerializeField] internal bool isAudioSpecie;
    [SerializeField] internal AudioClip soundSpecie;

    [Header("SETTINGS PLANTS")]
    [TextArea(0, 20)]
    [SerializeField] internal string habitPlant;
    [TextArea(0, 20)]
    [SerializeField] internal string longevityPlant;

    [Space(15)]
    [SerializeField] internal bool isOtherColorPlant;
    [SerializeField] internal Color[] colorRepresentativePlant;

}

